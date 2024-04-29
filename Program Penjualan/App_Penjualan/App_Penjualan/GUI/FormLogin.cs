using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace App_Penjualan.GUI
{
    public partial class FormLogin : Form
    {
        //private SqlCommand cmd;
        //private DataSet ds;
        //private SqlDataAdapter da;
        //private SqlDataReader reader;
        //Menu_Utama menu;

        //Kelas.Koneksi konn = new Kelas.Koneksi();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                if (textBox1.Text == "ADM001" && textBox2.Text == "ADMIN")
                {

                    Menu_Utama menu = new Menu_Utama();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Kode atau Password yang anda masukkan salah!");
                }

            
        }
        private void button2_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }
        
    }
}

