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
    public partial class Form6 : Form
    {
        public string fu { get; set; }
        public string ieo { get; set; }
        public string Lo { get; set; }
        public string Mo { get; set; }
        public string Sc { get; set; }
        public string Poi { get; set; }
        public string kok { get; set; }
        public string opF { get; set; }
        public Form6()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            bunifuLabel13.Text = fu;
            bunifuLabel17.Text = ieo;
            bunifuLabel18.Text = Lo;
            bunifuLabel19.Text = Mo;
            bunifuLabel20.Text = opF;
    //      bunifuLabel21.Text = ;
            bunifuLabel21.Text = Sc;
            bunifuLabel22.Text = Poi;
        }
    }
}
