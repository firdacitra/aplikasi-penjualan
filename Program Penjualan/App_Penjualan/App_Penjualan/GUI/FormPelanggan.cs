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
    public partial class FormPelanggan : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Kelas.Koneksi konn = new Kelas.Koneksi();

        void bersih()
        {
            textBox_idpelanggan.Text = "";
            textBox_NamaPelanggan.Text = "";
            textBox_notelp.Text = "";
            textBox_Alamat.Text = "";
            textBox_NamaPelanggan.Focus();
        }

        void atur_tombol(Boolean status)
        {
            button_ubah.Enabled = status;
            button_hapus.Enabled = status;
        }


        public FormPelanggan()
        {
            InitializeComponent();
            bersih();
            atur_tombol(false);
            refresh_pelanggan();
            auto_number();
        }

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
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "tbl_pelanggan";
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.Refresh();
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
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "tbl_pelanggan";
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.Refresh();
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

        void auto_number()
        {
            long hitung;
            string urut;
            SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select IdPelanggan from tbl_pelanggan where IdPelanggan in (select max (IdPelanggan) from tbl_pelanggan) order by IdPelanggan desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["IdPelanggan"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urut = "P" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "P001";
            }
            rd.Close();
            textBox_idpelanggan.Enabled = false;
            textBox_idpelanggan.Text = urut;
            conn.Close();

        }
        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            cari_pelanggan();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            if (textBox_idpelanggan.Text.Trim()== "" || textBox_NamaPelanggan.Text.Trim()== "" || textBox_Alamat.Text.Trim()== "" || textBox_notelp.Text.Trim()== "")
            {
                MessageBox.Show("Data belum lengkap, lengkapi data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into tbl_pelanggan values ('" + textBox_idpelanggan.Text + "','" + textBox_NamaPelanggan.Text + "','" + textBox_Alamat.Text + "','" + textBox_notelp.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil di simpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_pelanggan();
                    bersih();
                    atur_tombol(false);
                    auto_number();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button_simpan.Enabled = false;
                atur_tombol(true);

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox_idpelanggan.Text = row.Cells["IdPelanggan"].Value.ToString();
                textBox_NamaPelanggan.Text = row.Cells["NamaPelanggan"].Value.ToString();
                textBox_Alamat.Text = row.Cells["Alamat"].Value.ToString();
                textBox_notelp.Text = row.Cells["NoTelepon"].Value.ToString();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            if (textBox_idpelanggan.Text.Trim()== "" || textBox_NamaPelanggan.Text.Trim()== "" || textBox_Alamat.Text.Trim()== "" || textBox_notelp.Text.Trim()== "")
            {
                MessageBox.Show("Data belum lengkap, lengkapi data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("update tbl_pelanggan set NamaPelanggan = '" + textBox_NamaPelanggan.Text + "', Alamat = '" + textBox_Alamat.Text+ "', NoTelepon = '"+ textBox_notelp.Text+ "' where IdPelanggan = '" +textBox_idpelanggan.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil di ubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_pelanggan();
                    bersih();
                    atur_tombol(false);
                    button_simpan.Enabled = true;
                    auto_number();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus data: "+ textBox_NamaPelanggan.Text + "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();

                {
                    cmd = new SqlCommand("delete from tbl_pelanggan where IdPelanggan = '" + textBox_idpelanggan.Text+ "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_pelanggan();
                    bersih();
                    atur_tombol(false);
                    button_simpan.Enabled = true;
                    auto_number();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

