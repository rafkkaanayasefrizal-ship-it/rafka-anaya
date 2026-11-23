namespace rafka_anaya
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.kodeBahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batasMinimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdBahan = new System.Windows.Forms.TextBox();
            this.nmBahan = new System.Windows.Forms.TextBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.NmcStok = new System.Windows.Forms.NumericUpDown();
            this.txtSatuan = new System.Windows.Forms.TextBox();
            this.txtHarga_satuan = new System.Windows.Forms.TextBox();
            this.nmcBatas_minimum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tambah = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmcStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcBatas_minimum)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeBahan,
            this.namaBahan,
            this.kategori,
            this.stok,
            this.satuan,
            this.hargaSatuan,
            this.batasMinimum,
            this.status});
            this.dataGridView.Location = new System.Drawing.Point(267, 26);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(505, 299);
            this.dataGridView.TabIndex = 0;
            // 
            // kodeBahan
            // 
            this.kodeBahan.HeaderText = "Kode bahan";
            this.kodeBahan.Name = "kodeBahan";
            this.kodeBahan.ReadOnly = true;
            // 
            // namaBahan
            // 
            this.namaBahan.HeaderText = "Nama Bahan";
            this.namaBahan.Name = "namaBahan";
            this.namaBahan.ReadOnly = true;
            // 
            // kategori
            // 
            this.kategori.HeaderText = "Kategori";
            this.kategori.Name = "kategori";
            this.kategori.ReadOnly = true;
            // 
            // stok
            // 
            this.stok.HeaderText = "Stok";
            this.stok.Name = "stok";
            this.stok.ReadOnly = true;
            // 
            // satuan
            // 
            this.satuan.HeaderText = "Satuan";
            this.satuan.Name = "satuan";
            this.satuan.ReadOnly = true;
            // 
            // hargaSatuan
            // 
            this.hargaSatuan.HeaderText = "Harga satuan";
            this.hargaSatuan.Name = "hargaSatuan";
            this.hargaSatuan.ReadOnly = true;
            // 
            // batasMinimum
            // 
            this.batasMinimum.HeaderText = "Batas minimum";
            this.batasMinimum.Name = "batasMinimum";
            this.batasMinimum.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // kdBahan
            // 
            this.kdBahan.Location = new System.Drawing.Point(44, 26);
            this.kdBahan.Multiline = true;
            this.kdBahan.Name = "kdBahan";
            this.kdBahan.Size = new System.Drawing.Size(189, 23);
            this.kdBahan.TabIndex = 1;
            // 
            // nmBahan
            // 
            this.nmBahan.Location = new System.Drawing.Point(45, 74);
            this.nmBahan.Multiline = true;
            this.nmBahan.Name = "nmBahan";
            this.nmBahan.Size = new System.Drawing.Size(189, 23);
            this.nmBahan.TabIndex = 1;
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(44, 125);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(189, 21);
            this.cbKategori.TabIndex = 2;
            // 
            // NmcStok
            // 
            this.NmcStok.Location = new System.Drawing.Point(45, 177);
            this.NmcStok.Name = "NmcStok";
            this.NmcStok.Size = new System.Drawing.Size(189, 20);
            this.NmcStok.TabIndex = 3;
            // 
            // txtSatuan
            // 
            this.txtSatuan.Location = new System.Drawing.Point(45, 218);
            this.txtSatuan.Multiline = true;
            this.txtSatuan.Name = "txtSatuan";
            this.txtSatuan.Size = new System.Drawing.Size(189, 23);
            this.txtSatuan.TabIndex = 1;
            // 
            // txtHarga_satuan
            // 
            this.txtHarga_satuan.Location = new System.Drawing.Point(45, 261);
            this.txtHarga_satuan.Multiline = true;
            this.txtHarga_satuan.Name = "txtHarga_satuan";
            this.txtHarga_satuan.Size = new System.Drawing.Size(189, 20);
            this.txtHarga_satuan.TabIndex = 1;
            // 
            // nmcBatas_minimum
            // 
            this.nmcBatas_minimum.Location = new System.Drawing.Point(45, 305);
            this.nmcBatas_minimum.Name = "nmcBatas_minimum";
            this.nmcBatas_minimum.Size = new System.Drawing.Size(189, 20);
            this.nmcBatas_minimum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kode bahan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama bahan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Satuan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Harga satuan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Batas minimum";
            // 
            // tambah
            // 
            this.tambah.BackColor = System.Drawing.Color.Cyan;
            this.tambah.Location = new System.Drawing.Point(322, 353);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(75, 23);
            this.tambah.TabIndex = 5;
            this.tambah.Text = "ADD";
            this.tambah.UseVisualStyleBackColor = false;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(451, 353);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 5;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delete.Location = new System.Drawing.Point(581, 353);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 5;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmcBatas_minimum);
            this.Controls.Add(this.NmcStok);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.txtHarga_satuan);
            this.Controls.Add(this.txtSatuan);
            this.Controls.Add(this.nmBahan);
            this.Controls.Add(this.kdBahan);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmcStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcBatas_minimum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox kdBahan;
        private System.Windows.Forms.TextBox nmBahan;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.NumericUpDown NmcStok;
        private System.Windows.Forms.TextBox txtSatuan;
        private System.Windows.Forms.TextBox txtHarga_satuan;
        private System.Windows.Forms.NumericUpDown nmcBatas_minimum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn batasMinimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}

