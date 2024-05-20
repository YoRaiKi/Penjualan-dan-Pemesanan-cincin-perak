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
    public partial class Form3 : Form
    {
        public string Apa { get; set; }
        public string A1 { get; set; }
        public string Buf { get; set; }
        public string B1 { get; set; }
        public string Cie { get; set; }
        public string C1 { get; set; }
        public string Dia { get; set; }
        public string D1 { get; set; }
        public string Eit { get; set; }
        public string E1 { get; set; }
        public string Fuka { get; set; }
        public string F1 { get; set; }
        public string Groo { get; set; }
        public string G1 { get; set; }
        public string Hai { get; set; }
        public string H1 { get; set; }
        public string O { get; set; }
        public string O1 { get; set; }
        public string P { get; set; }
        public string P1 { get; set; }
        public string Q { get; set; }
        public string Q1 { get; set; }
        public string R { get; set; }
        public string R1 { get; set; }
        public string S { get; set; }
        public string S1 { get; set; }
        public string T { get; set; }
        public string T1 { get; set; }
        public string U { get; set; }
        public string U1 { get; set; }
        public string V { get; set; }
        public string V1 { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void bunifuLabel13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.jumlah = numericUpDown1.Text;
            form5.ukur = comboBox1.Text;
            form5.nama1 = bunifuTextBox3.Text;
            form5.alamat1 = bunifuTextBox4.Text;
            form5.Email1 = bunifuTextBox6.Text;
            form5.no1 = bunifuTextBox7.Text;
            form5.tanggal1 = bunifuDatePicker1.Text;
            form5.harga = label3.Text;
            form5.Show();
            this.Hide();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        { 
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel15_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label4.Text = Apa;
            label5.Text = A1;

            label4.Text = Buf;
            label5.Text = B1;

            label4.Text = Cie;
            label5.Text = C1;

            label4.Text = Dia;
            label5.Text = D1;

            label4.Text = Eit;
            label5.Text = E1;

            label4.Text = Fuka;
            label5.Text = F1;

            label4.Text = Groo;
            label5.Text = G1;

            label4.Text = Hai;
            label5.Text = H1;

            label4.Text = O;
            label5.Text = O1;

            label4.Text = P;
            label5.Text = P1;

            label4.Text = Q;
            label5.Text = Q1;

            label4.Text = R;
            label5.Text = R1;

            label4.Text = S;
            label5.Text = S1;

            label4.Text = T;
            label5.Text = T1;

            label4.Text = U;
            label5.Text = U1;

            label4.Text = V;
            label5.Text = V1;
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
