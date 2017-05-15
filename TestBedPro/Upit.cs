using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBedPro
{
    public partial class Upit : Form
    {
        public int x { get; set; }
        public int y { get; set; }
        public Upit()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(txt_x.Text);
            y = Convert.ToInt32(txt_y.Text);
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
