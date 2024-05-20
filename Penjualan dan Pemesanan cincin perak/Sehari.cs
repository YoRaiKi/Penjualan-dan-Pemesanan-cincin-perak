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
    public partial class Sehari : Form
    {
        public Sehari()
        {
            InitializeComponent();
        }

        private void Sehari_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.O = label1.Text;
            a.O1 = label9.Text;
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3();
            b.P = label2.Text;
            b.P1 = label10.Text;
            b.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            c.Q = label3.Text;
            c.Q1 = label11.Text;
            c.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 d = new Form3();
            d.R = label4.Text;
            d.R1 = label12.Text;
            d.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form3 Ia = new Form3();
            Ia.S = label5.Text;
            Ia.S1 = label13.Text;
            Ia.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.T = label6.Text;
            f.T1 = label14.Text;
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form3 g = new Form3();
            g.U = label7.Text;
            g.U1 = label15.Text;
            g.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 h = new Form3();
            h.V = label8.Text;
            h.V1 = label16.Text;
            h.ShowDialog();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
