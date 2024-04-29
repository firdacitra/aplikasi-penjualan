using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Penjualan.GUI
{
    public partial class Menu_Utama : Form
    {
        
        FormBarang brg;
        FormPelanggan plgn;
        FormTransaksi trx;
        private int childFormNumber = 0;

        void brg_FormClosed(object sender, FormClosedEventArgs e)
        {
            brg = null;
        }

        void plgn_FormClosed(object sender, FormClosedEventArgs e)
        {
            plgn = null;
        }

        void trx_FormClosed(object sender, FormClosedEventArgs e)
        {
            plgn = null;
        }
        public Menu_Utama()
        {
            InitializeComponent();
        }

        private void submenu_barang_Click(object sender, EventArgs e)
        {
            if (brg == null)
            {
                brg = new FormBarang();
                brg.MdiParent = this;
                brg.FormClosed += new FormClosedEventHandler ( brg_FormClosed);
                brg.Show();
            }
            else
            {
                brg.Activate();
            }
        }

        private void submenu_pelanggan_Click(object sender, EventArgs e)
        {
            if (plgn == null)
            {
                plgn = new FormPelanggan();
                plgn.MdiParent = this;
                plgn.FormClosed += new FormClosedEventHandler(brg_FormClosed);
                plgn.Show();
            }
            else
            {
                plgn.Activate();
            }
        }

        private void submenu_penjualan_Click(object sender, EventArgs e)
        {
            if (trx == null)
            {
                trx = new FormTransaksi();
                trx.MdiParent = this;
                trx.FormClosed += new FormClosedEventHandler(trx_FormClosed);
                trx.Show();
            }
            else
            {
                trx.Activate();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void submenu_info_Click(object sender, EventArgs e)
        {
            Tentang_Aplikasi info = new Tentang_Aplikasi();
            info.Show();
        }

        private void submenu_login_Click(object sender, EventArgs e)
        {

            FormLogin login = new FormLogin();
            login.Show();
        }

        private void submenu_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apakah anda yakin ingin keluar dari aplikasi?");
            Application.Exit();
        }

        private void submenu_keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
