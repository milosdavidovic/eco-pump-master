namespace TestBedPro
{
    partial class TestBedPro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_prodNo = new System.Windows.Forms.TextBox();
            this.btn_da = new System.Windows.Forms.Button();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.statusBarPanel = new System.Windows.Forms.StatusStrip();
            this.btn_init = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_q = new System.Windows.Forms.Label();
            this.lbl_h = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_uL1 = new System.Windows.Forms.Label();
            this.lbl_iL1 = new System.Windows.Forms.Label();
            this.lbl_u3p = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_iL2 = new System.Windows.Forms.Label();
            this.lbl_uL2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_i3p = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_iL3 = new System.Windows.Forms.Label();
            this.lbl_uL3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_cosphi3p = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.podešavanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podesavanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pB_q = new System.Windows.Forms.ProgressBar();
            this.pB_h = new System.Windows.Forms.ProgressBar();
            this.h1 = new System.Windows.Forms.TextBox();
            this.q1 = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lbl_p3p = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(12, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 600);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // txt_prodNo
            // 
            this.txt_prodNo.Location = new System.Drawing.Point(488, 36);
            this.txt_prodNo.Name = "txt_prodNo";
            this.txt_prodNo.Size = new System.Drawing.Size(134, 20);
            this.txt_prodNo.TabIndex = 2;
            this.txt_prodNo.TextChanged += new System.EventHandler(this.txt_prodNo_TextChanged);
            // 
            // btn_da
            // 
            this.btn_da.Location = new System.Drawing.Point(628, 34);
            this.btn_da.Name = "btn_da";
            this.btn_da.Size = new System.Drawing.Size(84, 23);
            this.btn_da.TabIndex = 3;
            this.btn_da.Text = "Potvrdi";
            this.btn_da.UseVisualStyleBackColor = true;
            this.btn_da.Click += new System.EventHandler(this.btn_da_Click);
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(12, 36);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(121, 21);
            this.deviceComboBox.TabIndex = 8;
            // 
            // statusBarPanel
            // 
            this.statusBarPanel.Location = new System.Drawing.Point(0, 964);
            this.statusBarPanel.Name = "statusBarPanel";
            this.statusBarPanel.Size = new System.Drawing.Size(1264, 22);
            this.statusBarPanel.TabIndex = 13;
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(139, 34);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(75, 23);
            this.btn_init.TabIndex = 12;
            this.btn_init.Text = "Init";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 733);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 228);
            this.dataGridView1.TabIndex = 15;
            // 
            // lbl_q
            // 
            this.lbl_q.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_q.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_q.Location = new System.Drawing.Point(1109, 27);
            this.lbl_q.Name = "lbl_q";
            this.lbl_q.Size = new System.Drawing.Size(125, 29);
            this.lbl_q.TabIndex = 16;
            this.lbl_q.Text = "0";
            this.lbl_q.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_h
            // 
            this.lbl_h.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_h.Location = new System.Drawing.Point(1109, 76);
            this.lbl_h.Name = "lbl_h";
            this.lbl_h.Size = new System.Drawing.Size(125, 29);
            this.lbl_h.TabIndex = 17;
            this.lbl_h.Text = "0";
            this.lbl_h.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(992, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Q  [m3/h]";
            // 
            // lbl_uL1
            // 
            this.lbl_uL1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_uL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_uL1.Location = new System.Drawing.Point(78, 25);
            this.lbl_uL1.Name = "lbl_uL1";
            this.lbl_uL1.Size = new System.Drawing.Size(66, 20);
            this.lbl_uL1.TabIndex = 18;
            this.lbl_uL1.Text = "0";
            this.lbl_uL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_iL1
            // 
            this.lbl_iL1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_iL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_iL1.Location = new System.Drawing.Point(81, 59);
            this.lbl_iL1.Name = "lbl_iL1";
            this.lbl_iL1.Size = new System.Drawing.Size(63, 20);
            this.lbl_iL1.TabIndex = 19;
            this.lbl_iL1.Text = "0";
            this.lbl_iL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_u3p
            // 
            this.lbl_u3p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_u3p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_u3p.Location = new System.Drawing.Point(84, 22);
            this.lbl_u3p.Name = "lbl_u3p";
            this.lbl_u3p.Size = new System.Drawing.Size(63, 20);
            this.lbl_u3p.TabIndex = 20;
            this.lbl_u3p.Text = "0";
            this.lbl_u3p.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(992, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "H [m]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "U [V]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(6, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "I [A]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(6, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "U 3P [V]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_iL1);
            this.groupBox1.Controls.Add(this.lbl_uL1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(1086, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 94);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "L1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbl_iL2);
            this.groupBox2.Controls.Add(this.lbl_uL2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(1086, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 90);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "L2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "I [A]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "U [V]";
            // 
            // lbl_iL2
            // 
            this.lbl_iL2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_iL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_iL2.Location = new System.Drawing.Point(81, 59);
            this.lbl_iL2.Name = "lbl_iL2";
            this.lbl_iL2.Size = new System.Drawing.Size(63, 20);
            this.lbl_iL2.TabIndex = 19;
            this.lbl_iL2.Text = "0";
            this.lbl_iL2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_uL2
            // 
            this.lbl_uL2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_uL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_uL2.Location = new System.Drawing.Point(81, 25);
            this.lbl_uL2.Name = "lbl_uL2";
            this.lbl_uL2.Size = new System.Drawing.Size(63, 20);
            this.lbl_uL2.TabIndex = 18;
            this.lbl_uL2.Text = "0";
            this.lbl_uL2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "I 3P [A]";
            // 
            // lbl_i3p
            // 
            this.lbl_i3p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_i3p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_i3p.Location = new System.Drawing.Point(84, 51);
            this.lbl_i3p.Name = "lbl_i3p";
            this.lbl_i3p.Size = new System.Drawing.Size(63, 20);
            this.lbl_i3p.TabIndex = 20;
            this.lbl_i3p.Text = "0";
            this.lbl_i3p.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lbl_iL3);
            this.groupBox3.Controls.Add(this.lbl_uL3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(1086, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 88);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "L3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(6, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "I [A]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "U [V]";
            // 
            // lbl_iL3
            // 
            this.lbl_iL3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_iL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_iL3.Location = new System.Drawing.Point(81, 59);
            this.lbl_iL3.Name = "lbl_iL3";
            this.lbl_iL3.Size = new System.Drawing.Size(63, 20);
            this.lbl_iL3.TabIndex = 19;
            this.lbl_iL3.Text = "0";
            this.lbl_iL3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_uL3
            // 
            this.lbl_uL3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_uL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_uL3.Location = new System.Drawing.Point(81, 25);
            this.lbl_uL3.Name = "lbl_uL3";
            this.lbl_uL3.Size = new System.Drawing.Size(63, 20);
            this.lbl_uL3.TabIndex = 18;
            this.lbl_uL3.Text = "0";
            this.lbl_uL3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(6, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Cos phi 3P";
            // 
            // lbl_cosphi3p
            // 
            this.lbl_cosphi3p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cosphi3p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_cosphi3p.Location = new System.Drawing.Point(84, 112);
            this.lbl_cosphi3p.Name = "lbl_cosphi3p";
            this.lbl_cosphi3p.Size = new System.Drawing.Size(63, 20);
            this.lbl_cosphi3p.TabIndex = 20;
            this.lbl_cosphi3p.Text = "0";
            this.lbl_cosphi3p.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Location = new System.Drawing.Point(220, 34);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 40;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podešavanjaToolStripMenuItem,
            this.oAplikacijiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // podešavanjaToolStripMenuItem
            // 
            this.podešavanjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podesavanjaToolStripMenuItem});
            this.podešavanjaToolStripMenuItem.Name = "podešavanjaToolStripMenuItem";
            this.podešavanjaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.podešavanjaToolStripMenuItem.Text = "Podešavanja";
            this.podešavanjaToolStripMenuItem.Click += new System.EventHandler(this.podešavanjaToolStripMenuItem_Click);
            // 
            // podesavanjaToolStripMenuItem
            // 
            this.podesavanjaToolStripMenuItem.Name = "podesavanjaToolStripMenuItem";
            this.podesavanjaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.podesavanjaToolStripMenuItem.Text = "Podesavanja";
            this.podesavanjaToolStripMenuItem.Click += new System.EventHandler(this.podesavanjaToolStripMenuItem_Click);
            // 
            // oAplikacijiToolStripMenuItem
            // 
            this.oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            this.oAplikacijiToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.oAplikacijiToolStripMenuItem.Text = "O aplikaciji";
            // 
            // pB_q
            // 
            this.pB_q.Location = new System.Drawing.Point(846, 26);
            this.pB_q.Name = "pB_q";
            this.pB_q.Size = new System.Drawing.Size(121, 30);
            this.pB_q.TabIndex = 43;
            // 
            // pB_h
            // 
            this.pB_h.Location = new System.Drawing.Point(846, 75);
            this.pB_h.Name = "pB_h";
            this.pB_h.Size = new System.Drawing.Size(121, 30);
            this.pB_h.Step = 100;
            this.pB_h.TabIndex = 43;
            // 
            // h1
            // 
            this.h1.Location = new System.Drawing.Point(821, 339);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(218, 20);
            this.h1.TabIndex = 44;
            // 
            // q1
            // 
            this.q1.Location = new System.Drawing.Point(821, 365);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(218, 20);
            this.q1.TabIndex = 45;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1086, 580);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(161, 35);
            this.btn_add.TabIndex = 48;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_p3p
            // 
            this.lbl_p3p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_p3p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_p3p.Location = new System.Drawing.Point(84, 80);
            this.lbl_p3p.Name = "lbl_p3p";
            this.lbl_p3p.Size = new System.Drawing.Size(63, 20);
            this.lbl_p3p.TabIndex = 20;
            this.lbl_p3p.Text = "0";
            this.lbl_p3p.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(6, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "P 3P [kW]";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(738, 643);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(161, 39);
            this.btn_save.TabIndex = 49;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.lbl_u3p);
            this.groupBox4.Controls.Add(this.lbl_i3p);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lbl_p3p);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.lbl_cosphi3p);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(1085, 413);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 144);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(821, 391);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 44;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(821, 417);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 20);
            this.textBox2.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(744, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Kontakt";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(744, 344);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Customer";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(744, 420);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "label5";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(744, 398);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Producr No.";
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(1091, 643);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(161, 35);
            this.btn_remove.TabIndex = 52;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // TestBedPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 986);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.q1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.h1);
            this.Controls.Add(this.pB_h);
            this.Controls.Add(this.pB_q);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_h);
            this.Controls.Add(this.lbl_q);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.statusBarPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.deviceComboBox);
            this.Controls.Add(this.btn_da);
            this.Controls.Add(this.txt_prodNo);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TestBedPro";
            this.Text = "Test Bed Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_prodNo;
        private System.Windows.Forms.Button btn_da;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.StatusStrip statusBarPanel;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_q;
        private System.Windows.Forms.Label lbl_h;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_uL1;
        private System.Windows.Forms.Label lbl_iL1;
        private System.Windows.Forms.Label lbl_u3p;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_i3p;
        private System.Windows.Forms.Label lbl_iL2;
        private System.Windows.Forms.Label lbl_uL2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_cosphi3p;
        private System.Windows.Forms.Label lbl_iL3;
        private System.Windows.Forms.Label lbl_uL3;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem podešavanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pB_q;
        private System.Windows.Forms.ProgressBar pB_h;
        private System.Windows.Forms.TextBox h1;
        private System.Windows.Forms.TextBox q1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbl_p3p;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem podesavanjaToolStripMenuItem;
        private System.Windows.Forms.Button btn_remove;
    }
}

