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
    public partial class Form5 : Form
    {
        public string nama1 { get; set; }
        public string alamat1 { get; set; }
        public string Email1 { get; set; }
        public string no1 { get; set; }
        public string tanggal1 { get; set; }    
        public string harga { get; set; }
        public string ukur { get; set; }
        public string jumlah { get; set; }
        public Form5()
        {
            InitializeComponent();
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Detail")
            {
                Form6 form6 = new Form6();
                form6.opF = jumlah;
                form6.fu = ukur;
                form6.ieo = nama1;
                form6.Lo = alamat1;
                form6.Mo = Email1;
                form6.Sc = no1;
                form6.Poi = tanggal1;
                form6.kok = harga;
                form6.Show();
                this.Hide();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           dataGridView1.Rows.Add(nama1, alamat1, Email1, no1, tanggal1, harga);
        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();  
            form7.Show();
            this.Hide();
        }
    }
}
