using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using iTextSharp.text;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace Sranje
{
    class tehKar
    {
        
        public string _referenca { get; set; }

       /* public string _opis 
        { 
            get { return ef.cenovnik.Find(_referenca).description.ToString(); }
            set { _opis = value; } 
        }*/
        public DataTable _karakteristike 
        { 
            get {return GetSpecificationsJSON(_referenca);}
            set { _karakteristike = value; } 
        }

        public iTextSharp.text.Image _kriva 
        {
            get
            {
                
                try   { return iTextSharp.text.Image.GetInstance(new Uri("https://product-selection.grundfos.com/product-detail.pumpcurve.png?productnumber=" + _referenca + "&frequency=50&languagecode=SRL&productrange=GMA&unitsystem=4&w=900&h=450&dpi=144")); }
                catch { return iTextSharp.text.Image.GetInstance("att.png"); }
            }
            set { _kriva = value; } 
        }

        public iTextSharp.text.Image _crtez 
        {
            get
            {
                try { return iTextSharp.text.Image.GetInstance(new Uri("http://net.grundfos.com/RestServer/imaging/dimdrawing/?productnumber=" + _referenca + "&frequency=50&languagecode=SRL&productrange=GMA&searchdomain=SALEABLE&unitsystem=4&UC.m3/h=UC_m3/h&w=1034&h=611&dpx=0&dpy=0")); }

                catch { return iTextSharp.text.Image.GetInstance("att.png"); }
            }
            set{ _crtez = value; }   //"http://net.grundfos.com/RestServer/imaging/dimdrawing/?productnumber=96401777&frequency=50&languagecode=SRL&unitsystem=4&UC.m3/h=UC_m3/h&w=1034&h=611&dpx=0&dpy=0"
        }

        public iTextSharp.text.Image _povezivanje 
        {
            get 
            {
                try   { return iTextSharp.text.Image.GetInstance(new Uri("http://net.grundfos.com/RestServer/imaging/wiringdiagram?productnumber="+_referenca+"&frequency=50&languagecode=SRL&unitsystem=4&UC.m3/h=UC_m3/h&w=1034&h=611&dpx=0&dpy=0")); } //"http://net.grundfos.com/RestServer/imaging/wiringdiagram?productnumber="+_referenca+"&frequency=50&languagecode=SRL&unitsystem=4&UC.m3/h=UC_m3/h&w=1034&h=611&dpx=0&dpy=0""
                catch { return iTextSharp.text.Image.GetInstance("att.png"); }
            }
            set{ _povezivanje = value; }  
        }

       /* public string _quotationtext 
        {
            get { return GetQuatationTextHTML(_referenca); }
            set { _quotationtext = value; } 
        }*/

        public int _x
        {
            get;
            set;
        }
        public int _y
        {
            get;
            set;
        }

        public class Datalist
        {
            public string name { get; set; }
            public string value { get; set; }

            public void dodaj(string n, string v)
            {

                //return Datalist;
            }
        }

        public class RootObject
        {
            public string id { get; set; }
            public string name { get; set; }
            public List<Datalist> datalist { get; set; }
        }
        public tehKar(string referenca)
        {
            _referenca = referenca;
        }
       
        private DataTable GetSpecificationsJSON(string referenca)
        {
            DataTable tehKaaar = new DataTable();
            Datalist tehKarak = new Datalist();
            tehKaaar.Columns.Add("Opis");
            tehKaaar.Columns.Add("Vrednost");
            // otvaramo vezu
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            Uri url = new Uri("http://product-selection.grundfos.com/product-detail.product.productdata.json?frequency=50&languagecode=SRL&unitsystem=4&productnumber=" + referenca);
            try
            {
                var data = client.DownloadString(url);
                var j = JsonConvert.DeserializeObject<List<RootObject>>(data);
                // vadimo podatke iz JSON odgovora i stavljamo u tabelu
            
                foreach (RootObject tehKarakteristike in j)
                {
                    tehKaaar.Rows.Add(tehKarakteristike.name, "");
                    foreach (Datalist listovi in tehKarakteristike.datalist)
                    {
                        tehKaaar.Rows.Add(listovi.name, listovi.value);
                        
                    }
                }
            }
            catch (Exception)
            {
            }
            return tehKaaar;
        }
       /* private string GetQuatationTextHTML(string referenca)
        {
            // otvaramo vezu
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            web.OverrideEncoding = Encoding.GetEncoding("ISO-8859-1");
            try
            {

                HtmlAgilityPack.HtmlDocument doc = web.Load("http://product-selection.grundfos.com/product-detail.quotationtext.html?frequency=50&languagecode=SRL&unitsystem=4&productnumber=" + referenca);

                StreamReader reader = new StreamReader(WebRequest.Create("http://product-selection.grundfos.com/product-detail.quotationtext.html?frequency=50&languagecode=SRL&unitsystem=4&productnumber=" + referenca).GetResponse().GetResponseStream(), Encoding.Default); //put your encoding 
                return doc.DocumentNode.InnerText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            
        }*/
    }
}

