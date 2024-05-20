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
    public partial class Form2 : Form
    {
        Pernikahan perni;
        Sehari eha;
        public Form2()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 0) { 
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnPer.Width = sidebar.Width;
                    pnSeh.Width = sidebar.Width;
                    pnSay.Width = sidebar.Width;
                    pnKem.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 158) {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnPer.Width = sidebar.Width;
                    pnSeh.Width = sidebar.Width;
                    pnSay.Width = sidebar.Width;
                    pnKem.Width = sidebar.Width;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (perni == null)
            {
                perni = new Pernikahan();
                perni.FormClosed += Perni_FormClosed;
                perni.MdiParent = this;
                perni.Show();
            }
            else
            {
                perni.Activate();
            }
        }

        private void Perni_FormClosed (object sender, FormClosedEventArgs e)
        {
            perni = null;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
            this.Hide();
        }
        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (eha == null)
            {
                eha = new Sehari();
                eha.FormClosed += Eha_FormClosed;
                eha.MdiParent = this;
                eha.Show();
            }
            else
            {
                eha.Activate();
            }
        }

        private void Eha_FormClosed (object sender, FormClosedEventArgs e)
        {
            eha = null;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
