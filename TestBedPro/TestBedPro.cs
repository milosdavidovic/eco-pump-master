using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp;
using System.Configuration;
using Modbus.Device;
using System.IO.Ports;
using iTextSharp.text.pdf;
using System.Globalization;
using System.Diagnostics;
using System.Threading;


namespace TestBedPro
{
    public partial class TestBedPro : Form
    {
        SerialPort _serialPort; 
        ModbusDevice _device;
        RadnaTacka _radnaTacka;
        List<RadnaTacka> _krivaPerformansi;

        int pritisak1;
        int protok1;

        double skalaX = 1;
        double skalaY = 1;
        double skalaP = 1;

        int nulaY= 375;
        int nulaX = 73;
        int nulaP = 588;

        int klikX = 1;
        int klikY = 1;
        int klikP = 1;

        int xtacka = 1;
        int ytacka = 1;
        int ptacka = 1;

        public TestBedPro()
        {
            InitializeComponent();

            _serialPort = new SerialPort();
            _device = new ModbusDevice();
            _radnaTacka = new RadnaTacka();
            _krivaPerformansi = new List<RadnaTacka>();
        }

        private void Initialize()
        {
            pictureBox1.Paint += pictureBox1_Paint;

            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;

            _serialPort.PortName = "COM1";
            _serialPort.BaudRate = 9600;
            _serialPort.DataBits = 8;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btn_start_Click(object sender, System.EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
                timer1.Enabled = true;
            }
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();

                }
                else
                {
                    MessageBox.Show("Port je vec otvoren '{0}'.", _serialPort.PortName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska prilikom otvaranja porta!\n {0}", ex.Message);
            }
           
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer1.Enabled = false;
            }
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();

                }
                else
                {
                    MessageBox.Show("Port je vec zatvoren '{0}'.", _serialPort.PortName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska prilikom zatvaranja porta!\n {0}", ex.Message);
            }
        }

        // povlači krivu sa GPC
        private void btn_da_Click(object sender, EventArgs e)
        {

            tehKar karakteristike = new tehKar(txt_prodNo.Text);

            double x = karakteristike._CurveSetX.maximum;
            double y = karakteristike._CurveSetY.maximum;

            labelX.Text = "Q max" + x.ToString();
            labelY.Text = "H max" + y.ToString();
            try
            {
                pictureBox1.Load((new Uri("https://product-selection.grundfos.com/product-detail.pumpcurve.png?productnumber=" + txt_prodNo.Text + "&frequency=50&languagecode=SRL&productrange=GMA&unitsystem=4&w=700&h=600&dpi=144")).ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
           
        }   

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _device.FetchData(_serialPort, 800);
            }
            catch (Exception ex)
            {
                //log error
            }

           pictureBox1.Invalidate();
        }

        private void txt_prodNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void podešavanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form podesavanja = new Podesavanja();
            podesavanja.Show();

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g1 = pictureBox1.CreateGraphics();
            Pen myPen1 = new Pen(Color.Pink);
            myPen1.Width = 2;
            g1.DrawLine(myPen1, e.X - 10, e.Y, e.X + 10, e.Y);
            g1.DrawLine(myPen1, e.X, e.Y - 10, e.X, e.Y + 10);
            if (e.Y > 400)
            {
                using (UpitP upit = new UpitP())
                {
                    if (upit.ShowDialog() == DialogResult.OK)
                    {
                        ptacka = upit.p;
                    }
                }
                klikP = e.X;

            }
            else if (e.Y < 375)
            {
                using (Upit upit = new Upit())
                {
                    if (upit.ShowDialog() == DialogResult.OK)
                    {
                        xtacka = upit.x;
                        ytacka = upit.y;
                    }
                }

                klikX = e.X;
                klikY = e.Y;
            }
        }
        
        // dodavanje radne tacke u report
        private void btn_add_Click(object sender, EventArgs e)
        {
            RadnaTacka temp = new RadnaTacka(_radnaTacka);
            temp._q = Convert.ToDouble(lbl_q.Text);
            temp._h = Convert.ToDouble(lbl_h.Text);
            //radnaTacka._q = Convert.ToDouble(lbl_q.Text);
          //  radnaTacka._h = Convert.ToDouble(lbl_h.Text);
            krivaPerformansi.Add(temp);
          //  krivaPerformansi.Add(radnaTacka);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource=krivaPerformansi;
        }
        
        // export radne tačke u report
        private void btn_save_Click(object sender, EventArgs e)
        {
            Graphics g1 = pictureBox1.CreateGraphics();///??
                      
            using (Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height,g1))
            {
                pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);
                bmp.Save(@"C:\test.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
           
            printPredracun();
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
          //  krivaPerformansi.Remove(radnaTacka.);

        }

        // crtanje krstica po pictureBox1
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            lbl_uL1.Text = _radnaTacka._uL1.ToString();
            lbl_uL2.Text = _radnaTacka._uL2.ToString();
            lbl_uL3.Text = _radnaTacka._uL3.ToString();

            lbl_iL1.Text = _radnaTacka._iL1.ToString();
            lbl_iL2.Text = _radnaTacka._iL2.ToString();
            lbl_iL3.Text = _radnaTacka._iL3.ToString();

            lbl_u3p.Text = _radnaTacka._u3p.ToString();
            lbl_i3p.Text = _radnaTacka._i3p.ToString();
            lbl_p3p.Text = _radnaTacka._p3p.ToString();
            lbl_cosphi3p.Text = _radnaTacka._cosphi3p.ToString();

            lbl_h.Text = Math.Round(_radnaTacka._h / 10, 2).ToString();
            lbl_q.Text = Math.Round(_radnaTacka._q / 10, 2).ToString();

            skalaX = (double)xtacka / ((double)klikX - (double)nulaX);
            skalaY = (double)ytacka / ((double)nulaY - (double)klikY);
            skalaP = (double)ptacka / ((double)nulaP - (double)klikP);

            try
            {
                pritisak1 = nulaY - Convert.ToInt32(_radnaTacka._h / 10 / skalaY);
                protok1 = nulaX + Convert.ToInt32(_radnaTacka._q / 10 / skalaX);
            }
            catch { }
            
            Pen myPen1 = new Pen(Color.DarkBlue, 2);
            Pen myPen2 = new Pen(Color.Red, 2);
            Pen myPen3 = new Pen(Color.Green, 2);

            //pictureBox1.Refresh();
            //crtaj krsic za svaku radnu tacku u krivoj performansi
            foreach (RadnaTacka rT in krivaPerformansi)
            {
                int tempX = nulaX + Convert.ToInt32(rT._q / skalaX);
                int tempY = nulaY - Convert.ToInt32(rT._h / skalaY);
                int tempP = nulaP - Convert.ToInt32(rT._p3p / skalaP);
                // krstic protok-pritisak
                e.Graphics.DrawLine(myPen1, tempX - 10, tempY, tempX + 10, tempY);
                e.Graphics.DrawLine(myPen1, tempX, tempY - 10, tempX, tempY + 10);
                // krstic protok-snaga
                e.Graphics.DrawLine(myPen3, tempX - 10, tempP, tempX + 10, tempP);
                e.Graphics.DrawLine(myPen3, tempX, tempP - 10, tempX, tempP + 10);

               // pictureBox1.Invalidate();
            }
            
            e.Graphics.DrawLine(myPen2, protok1 - 10, pritisak1, protok1 + 10, pritisak1);
            e.Graphics.DrawLine(myPen2, protok1, pritisak1 - 10, protok1, pritisak1 + 10);

            //this.Invoke(new EventHandler(TimerEventProcessor));

        }
        // ###########################################################################
        // podešavanja za ExportPDF
        string memorandumBlank = "memorandum_blanc.pdf";
        string memorandumTehKar = "tehKar.pdf";
        string noviDok = "\\\\EKOBAZA\\Prodaja\\2015\\Ponude\\";
        private BaseFont bfRob = BaseFont.CreateFont("C:\\Roboto-Condensed.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        private iTextSharp.text.Font font14 = new iTextSharp.text.Font(BaseFont.CreateFont("C:\\Roboto-Condensed.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED), 14);
        private iTextSharp.text.Font font9 = new iTextSharp.text.Font(BaseFont.CreateFont("C:\\Roboto-Condensed.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED), 9);
        public void printPredracun()
        {
        
            PdfReader reader = new PdfReader(memorandumBlank);
            PdfReader readerTK = new PdfReader(memorandumTehKar);
            iTextSharp.text.Rectangle size = reader.GetPageSizeWithRotation(1);

            Document document = new Document(size, 30f, 5f, 5f, 5f);
            // open the writer
            FileStream fs = new FileStream(noviDok +  "-"  + ".pdf", FileMode.Create, FileAccess.Write);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            
            
            document.Open();

            PdfContentByte cb = writer.DirectContent;
            cb.SetColorFill(BaseColor.BLACK);
            cb.SetFontAndSize(bfRob, 10);
            // import postojeceg dokumenta
            PdfImportedPage page = writer.GetImportedPage(readerTK, 1);
            cb.AddTemplate(page, 0, 0);

            // pisanje teksta u dokument po apsolutnim koordinatama
            cb.BeginText();
            //cb.ShowTextAligned(0, "nk", 53, 527, 0);
            //cb.ShowTextAligned(0, "Za Eko Inženjering", 53, 124, 0);
           
            cb.EndText();

            document.Add(new Paragraph(60, "\u00a0"));
            // naslov dokumenta
            PdfPTable naslov = new PdfPTable(2);

            naslov.TotalWidth = 500f;
            naslov.LockedWidth = true;
            float[] sirinaNaslov = new float[] { 206f, 294f };
            naslov.SetWidths(sirinaNaslov);
           // naslov.HorizontalAlignment = Element.ALIGN_LEFT;
           
            addCell(naslov, "IZVEŠTAJ TESTIRANJA" , 1, 1, 1, 11, 1);
            addCell(naslov, "####", 1, 1, 1, 11, 1);
            addCell(naslov, "Datum: "  , 1, 1, 1, 11, 0);
            addCell(naslov, DateTime.Today.Date.ToShortDateString(), 1, 1, 0, 11, 1);
            addCell(naslov, "Korisnik", 1, 1, 0, 11, 1);
            addCell(naslov, _radnaTacka._korisnik, 1, 1, 0, 11, 1);
            
            addCell(naslov, _radnaTacka._referenca, 1, 1, 0, 11, 1);
            document.Add(naslov);

            // razmak
            iTextSharp.text.Image slika =  iTextSharp.text.Image.GetInstance("c:\\test.jpg");
            slika.ScalePercent(74f);
            slika.SetAbsolutePosition(50f,280f);
            
            document.Add(slika);
            document.Add(new Paragraph(500, "\u00a0"));
            //
            //dodavanje tabele
            PdfPTable pdfTable = new PdfPTable(9);

            //širina tabele u PT
            pdfTable.TotalWidth = 524f;
            //fiksiranje apsolutne širine
            pdfTable.LockedWidth = true;
            // širine pojedinih ćelija
            float[] widths = new float[] { 20f, 60f, 60f, 60f, 60f, 60f, 60f, 60f, 60f };
            pdfTable.SetWidths(widths);

            addCell(pdfTable, "Poz.", 1, 1);
            addCell(pdfTable, "Protok", 1, 1);
            addCell(pdfTable, "Visina Dizanja", 1, 1);
            addCell(pdfTable, "Napon 3P", 1, 1);
            addCell(pdfTable, "Jačina struje L1", 1, 1);
            addCell(pdfTable, "Jačina struje L2", 1, 1);
            addCell(pdfTable, "Jačina struje L3", 1, 1);
            addCell(pdfTable, "Snaga P1", 1, 1);
            addCell(pdfTable, "Cosphi 3P", 1, 1);

            addCell(pdfTable, "", 1, 1);
            addCell(pdfTable, "[m3/h]", 1, 1);
            addCell(pdfTable, "[m]", 1, 1);
            addCell(pdfTable, "[V]", 1, 1);
            addCell(pdfTable, "[A]", 1, 1);
            addCell(pdfTable, "[A]", 1, 1);
            addCell(pdfTable, "[A]", 1, 1);
            addCell(pdfTable, "[W]", 1, 1);
            addCell(pdfTable, "", 1, 1);
           
            int i =1;
            foreach (RadnaTacka r  in krivaPerformansi)
            {
                addCell(pdfTable, i.ToString()          , 1, 1, 0, 9, 1);
                addCell(pdfTable, r._q.ToString()       , 1, 1, 0, 9, 1);
                addCell(pdfTable, r._h.ToString()       , 1, 1, 0, 9, 1);
                addCell(pdfTable, r._u3p.ToString()     , 1, 1, 0, 9, 1);
                addCell(pdfTable, r._iL1.ToString()     , 1, 1, 0, 9, 1);
                addCell(pdfTable, r._iL2.ToString()     , 1, 1, 0, 9, 1);
                addCell(pdfTable, r._iL3.ToString()     , 1, 1, 0, 9, 1);
                addCell(pdfTable, r._p3p.ToString()     , 1, 1, 0, 9, 1);
                addCell(pdfTable, r._cosphi3p.ToString(), 1, 1, 0, 9, 1);
                i++;

            }
          

            document.Add(pdfTable);

            // close the streams and voilá the file should be changed :)
            document.Close();
            
            fs.Close();
            writer.Close();
            reader.Close();

            System.Diagnostics.Process.Start(noviDok  + ( "-"  + ".pdf"));
    }

        private static void addCell(PdfPTable table, string text, int rowspan, int colspan, int alligment, int fontVel, int border) // treba ubaciti Aligment, funciju iskoristiti u foreach gore
        {
            BaseFont bfRob = BaseFont.CreateFont("C:\\Roboto-Condensed.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bfRob, fontVel);

            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.Rowspan = rowspan;
            cell.Colspan = colspan;
           // cell.Border = border;
            switch (alligment)
            {
                case 1:
                    cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                    break;
                case 2:
                    cell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                    break;
                default:
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    break;
            }
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            table.AddCell(cell);
        }
        private static void addCell(PdfPTable table, string text, int rowspan, int colspan)
        {
            BaseFont bfRob = BaseFont.CreateFont("C:\\Roboto-Condensed.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bfRob, 9);

            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.Rowspan = rowspan;
            cell.Colspan = colspan;
            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            table.AddCell(cell);
        }

        private void podesavanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
