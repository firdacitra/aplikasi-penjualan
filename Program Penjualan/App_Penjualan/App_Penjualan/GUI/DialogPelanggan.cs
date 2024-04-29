using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App_Penjualan.GUI
{
    public partial class DialogPelanggan : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string idpelanggan, namapelanggan = "";
        public string ambil_id_pelanggan
        {
            get
            {
                return idpelanggan;
            }
        }

        public string ambil_nama_pelanggan
        {
            get
            {
                return namapelanggan;
            }
        }
        Kelas.Koneksi konn = new Kelas.Koneksi();

        void refresh_pelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_pelanggan", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_pelanggan");
                    dataGridView_plg.DataSource = ds;
                    dataGridView_plg.DataMember = "tbl_pelanggan";
                    dataGridView_plg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_plg.AllowUserToAddRows = false;
                    dataGridView_plg.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void cari_pelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_pelanggan where IdBarang like '%" + textBox_cari.Text + "%' or NamaPelanggan like '%" + textBox_cari.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_pelanggan");
                    dataGridView_plg.DataSource = ds;
                    dataGridView_plg.DataMember = "tbl_pelanggan";
                    dataGridView_plg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_plg.AllowUserToAddRows = false;
                    dataGridView_plg.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            cari_pelanggan();
        }

        private void dataGridView_plg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                DataGridViewRow row = this.dataGridView_plg.Rows[e.RowIndex];
                idpelanggan = row.Cells["IdPelanggan"].Value.ToString();
                namapelanggan = row.Cells["NamaPelanggan"].Value.ToString();
                this.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public DialogPelanggan()
        {
            InitializeComponent();
            refresh_pelanggan();
        }
    }

   
}
