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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_Penjualan.GUI
{
    public partial class FormTransaksi : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        Kelas.Koneksi konn = new Kelas.Koneksi();

        private void bersih()
        {
            textBox_nokwit.Text = "";
            dateTimePicker_tgl.Value = DateTime.Now;
            textBox_idplg.Text = "";
            textBox_nmplg.Text = "";
            textBox_kodebrg.Text = "";
            textBox_namabrg.Text = "";
            textBox_hargabrg.Text = "0";
            textBox_jumlah.Text = "0";
            textBox_idplg.Enabled = false;
            textBox_nmplg.Enabled = false;
            textBox_kodebrg.Enabled = false ;
            textBox_namabrg.Enabled = false;
            textBox_hargabrg.Enabled = false;
            button_min.Enabled = false;
            button_simpan.Enabled = false;
        }

        void awal()
        {
            bersih();
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM vw_penjualan order by NoKwitansi DESC", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_penjualan");
                    dataGridView_trx.DataSource = ds;
                    dataGridView_trx.DataMember = "vw_penjualan";
                    dataGridView_trx.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_trx.AllowUserToAddRows = false;
                    dataGridView_trx.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
                groupBox_data.Enabled = false;
            }
        }

        private void auto_number()
        {
            long hitung;
            string urut;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select NoKwitansi from tbl_penjualan where NoKwitansi in (SELECT MAX (NoKwitansi) from tbl_penjualan) order by NoKwitansi desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NoKwitansi"].ToString().Length -12, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "Trx-" + joinstr.Substring(joinstr.Length - 4, 4) + "/" + DateTime.Now.ToString("MM/yyyy");
            }
            else
            {
                urut = "Trx-0001/" + DateTime.Now.ToString("MM/yyyy");
            }
            rd.Close();
            textBox_nokwit.Text = urut;
            textBox_nokwit.Enabled = false;
            conn.Close();

        }

        private void refresh_penjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM vw_detail where NoKwitansi = '" + textBox_nokwit.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_detail");
                    dataGridView_trx.DataSource = ds;
                    dataGridView_trx.DataMember = "vw_detail";
                    dataGridView_trx.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_trx.AllowUserToAddRows = false;
                    dataGridView_trx.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally { conn.Close(); }
            }
        }

        private void RefreshTransaksi()
        {
            refresh_penjualan();
            textBox_kodebrg.Clear();
            textBox_namabrg.Clear();
            textBox_hargabrg.Text = "0";
            textBox_jumlah.Text = "0";
            textBox_jumlah.Focus();
        }

        private void totalseluruh()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                cmd = new SqlCommand("select sum(Harga*Jumlah) as TotalBayar from vw_detail where NoKwitansi = '" + textBox_nokwit.Text + "'", conn);
                cmd.Connection = conn;
                int result = ((int)cmd.ExecuteScalar());
                String TotalSeluruh = result.ToString();
                label_total.Text = result.ToString();
                conn.Close();
            }
        }

        public FormTransaksi()
        {
            InitializeComponent();
            //bersih();
            awal();
            auto_number();
        }

        private void button_cariplg_Click(object sender, EventArgs e)
        {
            DialogPelanggan plgn = new DialogPelanggan();
            plgn.ShowDialog();
            textBox_idplg.Text = plgn.ambil_id_pelanggan;
            textBox_nmplg.Text = plgn.ambil_nama_pelanggan;
        }

        private void button_caribrg_Click(object sender, EventArgs e)
        {
            DialogBarang brg = new DialogBarang();
            brg.ShowDialog();
            textBox_kodebrg.Text = brg.ambil_kode_barang;
            textBox_namabrg.Text = brg.ambil_nama_barang;
            textBox_hargabrg.Text =  brg.ambil_harga;
        }

        private void button_baru_Click(object sender, EventArgs e)
        {
            awal();
            auto_number();
            dateTimePicker_tgl.Focus();
            button_cariplg.Enabled = true;
        }

        private void Simpan_MasterPenjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tbl_penjualan values('" + textBox_nokwit.Text + "','" + dateTimePicker_tgl.Text + "','" + textBox_idplg.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void Simpan_DetailPenjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tbl_detailpenjualan values('" + textBox_nokwit.Text + "','" + textBox_kodebrg.Text + "','" + textBox_jumlah.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                if (textBox_nokwit.Text.Trim()== "" || textBox_idplg.Text.Trim()== "" || textBox_kodebrg.Text.Trim()== "" || textBox_jumlah.Text.Trim()=="")
                {
                    MessageBox.Show("Data belum lengkap, lengkapi data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_penjualan where NoKwitansi = '" + textBox_nokwit.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Simpan_DetailPenjualan();
                        totalseluruh();
                    }
                    else
                    {
                        Simpan_MasterPenjualan();
                        Simpan_DetailPenjualan();
                        totalseluruh();
                    }
                    button_cariplg.Enabled = false;
                    button_simpan.Enabled = true;
                    groupBox_data.Enabled = true;
                    RefreshTransaksi();
                }
            }
        }

        private void dataGridView_trx_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button_plus.Enabled = false;
            button_min.Enabled = true;
            DataGridViewRow row = this.dataGridView_trx.Rows[e.RowIndex];
            textBox_kodebrg.Text = row.Cells["KodeBarang"].Value.ToString();
            textBox_namabrg.Text = row.Cells["NamaBarang"].Value.ToString();
            textBox_hargabrg.Text = row.Cells["Harga"].Value.ToString();
            textBox_jumlah.Text = row.Cells["Jumlah"].Value.ToString();
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("delete from tbl_detailpenjualan where NoKwitansi = '"+ textBox_nokwit.Text + "' AND KodeBarang = '" +textBox_kodebrg.Text +"'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                totalseluruh();
                Refresh();
                button_plus.Enabled = true;
                button_min.Enabled= false;

            }
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaksi Selesai");

            awal();
            label_total.Text = "0";
            button_cariplg.Enabled = true;

            auto_number();
        }
    }
}
