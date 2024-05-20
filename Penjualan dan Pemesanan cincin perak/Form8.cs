using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penjualan_dan_Pemesanan_cincin_perak
{
    public partial class Form8 : Form
    {
        public string nam { get; set; }
        public string ala { get; set; }
        public string ema { get; set; }
        public string n { get; set; }
        public string tan { get; set; } 
        public string li { get; set; }
        public string jul { get; set; } 
        public string uk { get; set; }
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            bunifuLabel2.Text = li;
            bunifuLabel3.Text = uk;
            bunifuLabel5.Text = nam;
            bunifuLabel6.Text = ala;
            bunifuLabel13.Text = ema;
            bunifuLabel14.Text = jul;
            bunifuLabel16.Text = n;
            bunifuLabel17.Text = tan;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();  
            form7.Show();
            this.Hide();
        }
    }
}
