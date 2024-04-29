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
using App_Penjualan.Kelas;

namespace App_Penjualan.GUI
{
    public partial class FormBarang : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Kelas.Koneksi konn = new Kelas.Koneksi();
        void bersih()
        {
            textBox_kodebarang.Text = "";
            textBox_namabarang.Text = "";
            textBox_hargabarang.Text = "0";
            textBox_stok.Text = "0";
            textBox_cari.Text = "";
            comboBox_satuan.Text = "-Pilih Satuan-";
        }

        void atur_tombol(Boolean status)
        {
            button_ubah.Enabled = status;
            button_hapus.Enabled = status;
        }

        void refresh_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_barang", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_barang");
                    dataGridView_barang.DataSource = ds;
                    dataGridView_barang.DataMember = "tbl_barang";
                    dataGridView_barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_barang.AllowUserToAddRows = false;
                    dataGridView_barang.Refresh();
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

        void cari_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_barang where KodeBarang like '%" + textBox_cari.Text + "%' or NamaBarang like '%" + textBox_cari.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_barang");
                    dataGridView_barang.DataSource = ds;
                    dataGridView_barang.DataMember = "tbl_barang";
                    dataGridView_barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_barang.AllowUserToAddRows = false;
                    dataGridView_barang.Refresh();
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
            cmd = new SqlCommand("select KodeBarang from tbl_barang where KodeBarang in (select max (KodeBarang) from tbl_barang) order by KodeBarang desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length - 2, 2)) + 1;
                string joinstr = "0000" + hitung;
                urut = "PK" + joinstr.Substring(joinstr.Length - 2, 2);
            }
            else
            {
                urut = "PK01";
            }
            rd.Close();
            textBox_kodebarang.Enabled = false;
            textBox_kodebarang.Text = urut;
            conn.Close();

        }
        public FormBarang()
        {
            InitializeComponent();
            bersih();
            atur_tombol(false);
            refresh_barang();
            auto_number();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus data: "+ textBox_namabarang.Text + "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
               
                {
                    cmd = new SqlCommand("delete from tbl_barang where KodeBarang = '" + textBox_kodebarang.Text+ "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_barang();
                    bersih();
                    atur_tombol(false);
                    button_simpan.Enabled = true;
                    auto_number();
                }
            }
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            cari_barang();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            if(textBox_kodebarang.Text.Trim()== "" || textBox_namabarang.Text.Trim()== "" || textBox_stok.Text.Trim()== "" || textBox_hargabarang.Text.Trim()== "" || textBox_hargabarang.Text.Trim()=="" || comboBox_satuan.Text.Trim()== "")
            {
                MessageBox.Show("Data belum lengkap, lengkapi data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into tbl_barang values ('" + textBox_kodebarang.Text + "','" + textBox_namabarang.Text + "','" + textBox_hargabarang.Text + "','" + textBox_stok.Text + "','" + comboBox_satuan.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil di simpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_barang();
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

        private void dataGridView_barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button_simpan.Enabled = false;
                atur_tombol(true);

                DataGridViewRow row = this.dataGridView_barang.Rows[e.RowIndex];
                textBox_kodebarang.Text = row.Cells["KodeBarang"].Value.ToString();
                textBox_namabarang.Text = row.Cells["NamaBarang"].Value.ToString();
                textBox_hargabarang.Text = row.Cells["Harga"].Value.ToString();
                textBox_stok.Text = row.Cells["Stok"].Value.ToString();
                comboBox_satuan.Text = row.Cells["Satuan"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            if (textBox_kodebarang.Text.Trim()== "" || textBox_namabarang.Text.Trim()== "" || textBox_stok.Text.Trim()== "" || textBox_hargabarang.Text.Trim()== "" || textBox_hargabarang.Text.Trim()=="" || comboBox_satuan.Text.Trim()== "")
            {
                MessageBox.Show("Data belum lengkap, lengkapi data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("update tbl_barang set NamaBarang = '" + textBox_namabarang.Text + "', Harga = '" + textBox_hargabarang.Text+ "', Stok = '"+ textBox_stok.Text+ "', Satuan = '" + comboBox_satuan.Text + "' where KodeBarang = '" +textBox_kodebarang.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil di ubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_barang();
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

        private void button_baru_Click(object sender, EventArgs e)
        {
            bersih();
            atur_tombol(false );
            button_simpan.Enabled = true ;
            auto_number();
        }
    }
}
