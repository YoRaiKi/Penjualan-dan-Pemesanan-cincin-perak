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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ukur = comboBox1.Text;
            form7.link = bunifuTextBox1.Text;
            form7.jumlah = numericUpDown1.Text;
            form7.nama = bunifuTextBox4.Text;
            form7.alamat = bunifuTextBox5.Text;
            form7.Email = bunifuTextBox6.Text;
            form7.no = bunifuTextBox3.Text;
            form7.tanggal = bunifuDatePicker1.Text;
            form7.Show();
            this.Hide();
        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form1 form4 = new Form1();
            form4.ShowDialog();
        }
    }
}
