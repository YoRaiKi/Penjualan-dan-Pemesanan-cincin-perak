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
    public partial class Form7 : Form
    {
        public string nama { get; set; }
        public string alamat { get; set; } 
        public string Email { get; set; }
        public string no { get; set; }  
        public string tanggal { get; set; }
        public string link { get; set; }
        public string jumlah { get; set; }
        public string ukur { get; set; }
        public Form7()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Detail")
            {
                Form8 form6 = new Form8();
                form6.nam = nama;
                form6.ala = alamat;
                form6.ema = Email;
                form6.n = no;
                form6.tan = tanggal;
                form6.li = link;
                form6.jul = jumlah;
                form6.uk = ukur;
                form6.Show();
                this.Hide();
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
             dataGridView1.Rows.Add(nama, alamat, Email, no, tanggal); 
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();    
        }
    }
}
