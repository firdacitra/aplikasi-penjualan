namespace App_Penjualan.GUI
{
    partial class DialogBarang
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
            this.dataGridView_brg = new System.Windows.Forms.DataGridView();
            this.groupBox_databrg = new System.Windows.Forms.GroupBox();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_brg)).BeginInit();
            this.groupBox_databrg.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_brg
            // 
            this.dataGridView_brg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_brg.Location = new System.Drawing.Point(16, 107);
            this.dataGridView_brg.Name = "dataGridView_brg";
            this.dataGridView_brg.RowHeadersWidth = 51;
            this.dataGridView_brg.RowTemplate.Height = 24;
            this.dataGridView_brg.Size = new System.Drawing.Size(909, 359);
            this.dataGridView_brg.TabIndex = 0;
            this.dataGridView_brg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_brg_CellDoubleClick);
            // 
            // groupBox_databrg
            // 
            this.groupBox_databrg.Controls.Add(this.textBox_cari);
            this.groupBox_databrg.Controls.Add(this.label1);
            this.groupBox_databrg.Controls.Add(this.dataGridView_brg);
            this.groupBox_databrg.Location = new System.Drawing.Point(12, 12);
            this.groupBox_databrg.Name = "groupBox_databrg";
            this.groupBox_databrg.Size = new System.Drawing.Size(947, 486);
            this.groupBox_databrg.TabIndex = 2;
            this.groupBox_databrg.TabStop = false;
            this.groupBox_databrg.Text = "Data Barang";
            // 
            // textBox_cari
            // 
            this.textBox_cari.Location = new System.Drawing.Point(279, 37);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(618, 22);
            this.textBox_cari.TabIndex = 2;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari Barang (Kode/Nama)";
            // 
            // DialogBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 517);
            this.Controls.Add(this.groupBox_databrg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBarang";
            this.Text = "Cari Barang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_brg)).EndInit();
            this.groupBox_databrg.ResumeLayout(false);
            this.groupBox_databrg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_brg;
        private System.Windows.Forms.GroupBox groupBox_databrg;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.Label label1;
    }
}