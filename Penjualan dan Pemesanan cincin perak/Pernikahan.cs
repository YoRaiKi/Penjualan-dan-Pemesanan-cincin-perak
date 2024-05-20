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
    public partial class Pernikahan : Form
    {
        public Pernikahan()
        {
            InitializeComponent();
        }

        private void Pernikahan_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Apa = label1.Text;
            a.A1 = label9.Text;
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3();
            b.Buf = label2.Text;
            b.B1 = label10.Text;
            b.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            c.Cie = label3.Text;
            c.C1 = label11.Text;
            c.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 d = new Form3();
            d.Dia = label4.Text;
            d.D1 = label12.Text;
            d.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form3 Ia = new Form3();
            Ia.Eit = label5.Text;
            Ia.E1 = label13.Text;
            Ia.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Fuka = label6.Text;
            f.F1 = label14.Text;
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form3 g = new Form3();
            g.Groo = label7.Text;
            g.G1 = label15.Text;
            g.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 h = new Form3();
            h.Hai = label8.Text;
            h.H1 = label16.Text;
            h.ShowDialog();
        }
        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel17_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel18_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel26_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel36_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel35_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel25_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel32_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel31_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel39_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel48_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel46_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel45_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel44_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel43_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel40_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel47_Click(object sender, EventArgs e)
        {

        }
    }
}
