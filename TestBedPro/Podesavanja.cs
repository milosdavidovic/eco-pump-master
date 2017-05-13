using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TestBedPro
{
    public partial class Podesavanja : Form
    {
        public Podesavanja()
        {
            
            InitializeComponent();
            string keyvalue = ConfigurationManager.AppSettings["keyname"];
            string numberOfBuffers = ConfigurationManager.AppSettings["NumberOfbuffers"];
            string clockFreq = ConfigurationManager.AppSettings["clockFreq"];
            string sensor0gain = ConfigurationManager.AppSettings["sensor0gain"];
            string sensor1gain = ConfigurationManager.AppSettings["sensor1gain"];
            string sensor0offset = ConfigurationManager.AppSettings["sensor0offset"];
            string sensor1offset = ConfigurationManager.AppSettings["sensor1offset"];

                txt_numbersOfBuffers.Text = numberOfBuffers;
             
                txt_frequency.Text = clockFreq;
                txt_gain0.Text = sensor0gain;
                txt_gainH.Text = sensor1gain;
                txt_offset0.Text = sensor0offset;
                txt_offsetH.Text = sensor1offset;

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            
            ConfigurationManager.AppSettings["NumberOfbuffers"] = txt_numbersOfBuffers.Text;
            ConfigurationManager.AppSettings["clockFreq"] = txt_frequency.Text;
            ConfigurationManager.AppSettings["sensor0gain"] = txt_gain0.Text;
            ConfigurationManager.AppSettings["sensor1gain"] = txt_gainH.Text;
            ConfigurationManager.AppSettings["sensor0offset"] = txt_offset0.Text;
            ConfigurationManager.AppSettings["sensor1offset"] = txt_offsetH.Text;

            this.Dispose();
        }

        private void Podesavanja_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
