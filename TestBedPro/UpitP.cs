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
    public partial class UpitP : Form
    {
        public int p { get; set; }
        public UpitP()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString()=="W")
            {
                p = Convert.ToInt16(txt_p.Text);
            }
            else
            {
                p = Convert.ToInt16(txt_p.Text)*1000;
            }
        
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
