namespace App_Penjualan.GUI
{
    partial class FormTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.dataGridView_trx = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.groupBox_ambilbrg = new System.Windows.Forms.GroupBox();
            this.button_min = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_caribrg = new System.Windows.Forms.Button();
            this.textBox_namabrg = new System.Windows.Forms.TextBox();
            this.textBox_jumlah = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_kodebrg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_hargabrg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_form = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_tgl = new System.Windows.Forms.DateTimePicker();
            this.button_cariplg = new System.Windows.Forms.Button();
            this.textBox_nokwit = new System.Windows.Forms.TextBox();
            this.textBox_nmplg = new System.Windows.Forms.TextBox();
            this.textBox_idplg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_trx)).BeginInit();
            this.groupBox_data.SuspendLayout();
            this.groupBox_ambilbrg.SuspendLayout();
            this.groupBox_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_simpan
            // 
            this.button_simpan.Location = new System.Drawing.Point(466, 531);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(103, 52);
            this.button_simpan.TabIndex = 23;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_baru
            // 
            this.button_baru.Location = new System.Drawing.Point(44, 531);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(87, 52);
            this.button_baru.TabIndex = 22;
            this.button_baru.Text = "Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // dataGridView_trx
            // 
            this.dataGridView_trx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_trx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_trx.Location = new System.Drawing.Point(22, 30);
            this.dataGridView_trx.Name = "dataGridView_trx";
            this.dataGridView_trx.RowHeadersWidth = 51;
            this.dataGridView_trx.RowTemplate.Height = 24;
            this.dataGridView_trx.Size = new System.Drawing.Size(516, 456);
            this.dataGridView_trx.TabIndex = 14;
            this.dataGridView_trx.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_trx_CellDoubleClick);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(772, 549);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Total Harga Rp.";
            // 
            // groupBox_data
            // 
            this.groupBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_data.Controls.Add(this.dataGridView_trx);
            this.groupBox_data.Location = new System.Drawing.Point(753, 12);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(559, 513);
            this.groupBox_data.TabIndex = 21;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = "Data Transaksi";
            // 
            // groupBox_ambilbrg
            // 
            this.groupBox_ambilbrg.Controls.Add(this.button_min);
            this.groupBox_ambilbrg.Controls.Add(this.button_plus);
            this.groupBox_ambilbrg.Controls.Add(this.button_caribrg);
            this.groupBox_ambilbrg.Controls.Add(this.textBox_namabrg);
            this.groupBox_ambilbrg.Controls.Add(this.textBox_jumlah);
            this.groupBox_ambilbrg.Controls.Add(this.label4);
            this.groupBox_ambilbrg.Controls.Add(this.label6);
            this.groupBox_ambilbrg.Controls.Add(this.textBox_kodebrg);
            this.groupBox_ambilbrg.Controls.Add(this.label3);
            this.groupBox_ambilbrg.Controls.Add(this.textBox_hargabrg);
            this.groupBox_ambilbrg.Controls.Add(this.label5);
            this.groupBox_ambilbrg.Location = new System.Drawing.Point(12, 268);
            this.groupBox_ambilbrg.Name = "groupBox_ambilbrg";
            this.groupBox_ambilbrg.Size = new System.Drawing.Size(697, 257);
            this.groupBox_ambilbrg.TabIndex = 20;
            this.groupBox_ambilbrg.TabStop = false;
            this.groupBox_ambilbrg.Text = "Ambil Barang";
            // 
            // button_min
            // 
            this.button_min.Location = new System.Drawing.Point(618, 185);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(43, 37);
            this.button_min.TabIndex = 20;
            this.button_min.Text = "-";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(569, 185);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(43, 37);
            this.button_plus.TabIndex = 19;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_caribrg
            // 
            this.button_caribrg.Location = new System.Drawing.Point(220, 77);
            this.button_caribrg.Name = "button_caribrg";
            this.button_caribrg.Size = new System.Drawing.Size(75, 23);
            this.button_caribrg.TabIndex = 13;
            this.button_caribrg.Text = "Cari";
            this.button_caribrg.UseVisualStyleBackColor = true;
            this.button_caribrg.Click += new System.EventHandler(this.button_caribrg_Click);
            // 
            // textBox_namabrg
            // 
            this.textBox_namabrg.Location = new System.Drawing.Point(354, 78);
            this.textBox_namabrg.Name = "textBox_namabrg";
            this.textBox_namabrg.Size = new System.Drawing.Size(331, 22);
            this.textBox_namabrg.TabIndex = 9;
            // 
            // textBox_jumlah
            // 
            this.textBox_jumlah.Location = new System.Drawing.Point(354, 173);
            this.textBox_jumlah.Name = "textBox_jumlah";
            this.textBox_jumlah.Size = new System.Drawing.Size(112, 22);
            this.textBox_jumlah.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jumlah";
            // 
            // textBox_kodebrg
            // 
            this.textBox_kodebrg.Location = new System.Drawing.Point(51, 77);
            this.textBox_kodebrg.Name = "textBox_kodebrg";
            this.textBox_kodebrg.Size = new System.Drawing.Size(149, 22);
            this.textBox_kodebrg.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kode Barang";
            // 
            // textBox_hargabrg
            // 
            this.textBox_hargabrg.Location = new System.Drawing.Point(51, 173);
            this.textBox_hargabrg.Name = "textBox_hargabrg";
            this.textBox_hargabrg.Size = new System.Drawing.Size(149, 22);
            this.textBox_hargabrg.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga Barang";
            // 
            // groupBox_form
            // 
            this.groupBox_form.Controls.Add(this.dateTimePicker_tgl);
            this.groupBox_form.Controls.Add(this.button_cariplg);
            this.groupBox_form.Controls.Add(this.textBox_nokwit);
            this.groupBox_form.Controls.Add(this.textBox_nmplg);
            this.groupBox_form.Controls.Add(this.textBox_idplg);
            this.groupBox_form.Controls.Add(this.label9);
            this.groupBox_form.Controls.Add(this.label7);
            this.groupBox_form.Controls.Add(this.label2);
            this.groupBox_form.Controls.Add(this.label1);
            this.groupBox_form.Location = new System.Drawing.Point(12, 12);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Size = new System.Drawing.Size(697, 234);
            this.groupBox_form.TabIndex = 26;
            this.groupBox_form.TabStop = false;
            this.groupBox_form.Text = "Form Transaksi Penjualan";
            // 
            // dateTimePicker_tgl
            // 
            this.dateTimePicker_tgl.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker_tgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_tgl.Location = new System.Drawing.Point(503, 76);
            this.dateTimePicker_tgl.Name = "dateTimePicker_tgl";
            this.dateTimePicker_tgl.Size = new System.Drawing.Size(182, 22);
            this.dateTimePicker_tgl.TabIndex = 26;
            // 
            // button_cariplg
            // 
            this.button_cariplg.Location = new System.Drawing.Point(220, 161);
            this.button_cariplg.Name = "button_cariplg";
            this.button_cariplg.Size = new System.Drawing.Size(75, 23);
            this.button_cariplg.TabIndex = 21;
            this.button_cariplg.Text = "Cari";
            this.button_cariplg.UseVisualStyleBackColor = true;
            this.button_cariplg.Click += new System.EventHandler(this.button_cariplg_Click);
            // 
            // textBox_nokwit
            // 
            this.textBox_nokwit.Location = new System.Drawing.Point(503, 33);
            this.textBox_nokwit.Name = "textBox_nokwit";
            this.textBox_nokwit.Size = new System.Drawing.Size(182, 22);
            this.textBox_nokwit.TabIndex = 25;
            // 
            // textBox_nmplg
            // 
            this.textBox_nmplg.Location = new System.Drawing.Point(359, 161);
            this.textBox_nmplg.Name = "textBox_nmplg";
            this.textBox_nmplg.Size = new System.Drawing.Size(326, 22);
            this.textBox_nmplg.TabIndex = 24;
            // 
            // textBox_idplg
            // 
            this.textBox_idplg.Location = new System.Drawing.Point(51, 161);
            this.textBox_idplg.Name = "textBox_idplg";
            this.textBox_idplg.Size = new System.Drawing.Size(149, 22);
            this.textBox_idplg.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tgl Transaksi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "No Kwitansi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Id Pelanggan";
            // 
            // label_total
            // 
            this.label_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(900, 549);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(14, 16);
            this.label_total.TabIndex = 27;
            this.label_total.Text = "0";
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1343, 607);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.groupBox_form);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.button_baru);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.groupBox_ambilbrg);
            this.Name = "FormTransaksi";
            this.Text = "Form Transaksi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_trx)).EndInit();
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_ambilbrg.ResumeLayout(false);
            this.groupBox_ambilbrg.PerformLayout();
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.DataGridView dataGridView_trx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.GroupBox groupBox_ambilbrg;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_caribrg;
        private System.Windows.Forms.TextBox textBox_namabrg;
        private System.Windows.Forms.TextBox textBox_jumlah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_kodebrg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_hargabrg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox_form;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tgl;
        private System.Windows.Forms.Button button_cariplg;
        private System.Windows.Forms.TextBox textBox_nokwit;
        private System.Windows.Forms.TextBox textBox_nmplg;
        private System.Windows.Forms.TextBox textBox_idplg;
        private System.Windows.Forms.Label label_total;
    }
}