namespace PeminjamanBuku
{
    partial class Peminjaman
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnTambahKat = new Button();
            btnDeleteKat = new Button();
            bntUpdateKat = new Button();
            dgvKategori = new DataGridView();
            btnSimpanKat = new Button();
            txtKategori = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            txtPenulis = new TextBox();
            label6 = new Label();
            cbKategori = new ComboBox();
            label5 = new Label();
            btnTambahBuk = new Button();
            btnDeleteBuk = new Button();
            btnUpdateBuk = new Button();
            dgvBuku = new DataGridView();
            btnSimpanBuk = new Button();
            txtBuku = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tabPage3 = new TabPage();
            label7 = new Label();
            cbStatus = new ComboBox();
            cbBuku = new ComboBox();
            label8 = new Label();
            btnTambahPem = new Button();
            btnDeletePem = new Button();
            btnUpdatePem = new Button();
            dgvPeminjam = new DataGridView();
            btnSimpanPem = new Button();
            txtNamaPeminjam = new TextBox();
            label9 = new Label();
            label10 = new Label();
            btnKembali = new Button();
            label11 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKategori).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuku).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeminjam).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 74);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(795, 585);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnTambahKat);
            tabPage1.Controls.Add(btnDeleteKat);
            tabPage1.Controls.Add(bntUpdateKat);
            tabPage1.Controls.Add(dgvKategori);
            tabPage1.Controls.Add(btnSimpanKat);
            tabPage1.Controls.Add(txtKategori);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(787, 547);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kategori";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTambahKat
            // 
            btnTambahKat.Location = new Point(485, 183);
            btnTambahKat.Name = "btnTambahKat";
            btnTambahKat.Size = new Size(112, 34);
            btnTambahKat.TabIndex = 15;
            btnTambahKat.Text = "Tambah";
            btnTambahKat.UseVisualStyleBackColor = true;
            btnTambahKat.Click += btnTambahKat_Click;
            // 
            // btnDeleteKat
            // 
            btnDeleteKat.Location = new Point(349, 183);
            btnDeleteKat.Name = "btnDeleteKat";
            btnDeleteKat.Size = new Size(112, 34);
            btnDeleteKat.TabIndex = 14;
            btnDeleteKat.Text = "Delete";
            btnDeleteKat.UseVisualStyleBackColor = true;
            btnDeleteKat.Click += btnDeleteKat_Click;
            // 
            // bntUpdateKat
            // 
            bntUpdateKat.Location = new Point(213, 183);
            bntUpdateKat.Name = "bntUpdateKat";
            bntUpdateKat.Size = new Size(112, 34);
            bntUpdateKat.TabIndex = 13;
            bntUpdateKat.Text = "Update";
            bntUpdateKat.UseVisualStyleBackColor = true;
            bntUpdateKat.Click += bntUpdateKat_Click;
            // 
            // dgvKategori
            // 
            dgvKategori.AllowUserToOrderColumns = true;
            dgvKategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategori.Location = new Point(63, 293);
            dgvKategori.Name = "dgvKategori";
            dgvKategori.RowHeadersWidth = 62;
            dgvKategori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKategori.Size = new Size(614, 225);
            dgvKategori.TabIndex = 12;
            dgvKategori.CellMouseDoubleClick += dgvKategori_CellMouseDoubleClick;
            // 
            // btnSimpanKat
            // 
            btnSimpanKat.Location = new Point(74, 183);
            btnSimpanKat.Name = "btnSimpanKat";
            btnSimpanKat.Size = new Size(112, 34);
            btnSimpanKat.TabIndex = 11;
            btnSimpanKat.Text = "Simpan";
            btnSimpanKat.UseVisualStyleBackColor = true;
            btnSimpanKat.Click += btnSimpanKat_Click;
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(164, 115);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(513, 31);
            txtKategori.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 118);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 9;
            label2.Text = "Kategori";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 36);
            label1.Name = "label1";
            label1.Size = new Size(129, 38);
            label1.TabIndex = 8;
            label1.Text = "Kategori";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtPenulis);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(cbKategori);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(btnTambahBuk);
            tabPage2.Controls.Add(btnDeleteBuk);
            tabPage2.Controls.Add(btnUpdateBuk);
            tabPage2.Controls.Add(dgvBuku);
            tabPage2.Controls.Add(btnSimpanBuk);
            tabPage2.Controls.Add(txtBuku);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(787, 547);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Buku";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPenulis
            // 
            txtPenulis.Location = new Point(153, 155);
            txtPenulis.Name = "txtPenulis";
            txtPenulis.Size = new Size(513, 31);
            txtPenulis.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 158);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 31;
            label6.Text = "Penulis";
            // 
            // cbKategori
            // 
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(153, 207);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(513, 33);
            cbKategori.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 207);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 29;
            label5.Text = "Kategori";
            // 
            // btnTambahBuk
            // 
            btnTambahBuk.Location = new Point(472, 265);
            btnTambahBuk.Name = "btnTambahBuk";
            btnTambahBuk.Size = new Size(112, 34);
            btnTambahBuk.TabIndex = 28;
            btnTambahBuk.Text = "Tambah";
            btnTambahBuk.UseVisualStyleBackColor = true;
            btnTambahBuk.Click += btnTambahBuk_Click;
            // 
            // btnDeleteBuk
            // 
            btnDeleteBuk.Location = new Point(336, 265);
            btnDeleteBuk.Name = "btnDeleteBuk";
            btnDeleteBuk.Size = new Size(112, 34);
            btnDeleteBuk.TabIndex = 27;
            btnDeleteBuk.Text = "Delete";
            btnDeleteBuk.UseVisualStyleBackColor = true;
            btnDeleteBuk.Click += btnDeleteBuk_Click;
            // 
            // btnUpdateBuk
            // 
            btnUpdateBuk.Location = new Point(200, 265);
            btnUpdateBuk.Name = "btnUpdateBuk";
            btnUpdateBuk.Size = new Size(112, 34);
            btnUpdateBuk.TabIndex = 26;
            btnUpdateBuk.Text = "Update";
            btnUpdateBuk.UseVisualStyleBackColor = true;
            btnUpdateBuk.Click += btnUpdateBuk_Click;
            // 
            // dgvBuku
            // 
            dgvBuku.AllowUserToOrderColumns = true;
            dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuku.Location = new Point(52, 341);
            dgvBuku.Name = "dgvBuku";
            dgvBuku.RowHeadersWidth = 62;
            dgvBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuku.Size = new Size(614, 225);
            dgvBuku.TabIndex = 25;
            dgvBuku.CellMouseDoubleClick += dgvBuku_CellMouseDoubleClick;
            // 
            // btnSimpanBuk
            // 
            btnSimpanBuk.Location = new Point(61, 265);
            btnSimpanBuk.Name = "btnSimpanBuk";
            btnSimpanBuk.Size = new Size(112, 34);
            btnSimpanBuk.TabIndex = 24;
            btnSimpanBuk.Text = "Simpan";
            btnSimpanBuk.UseVisualStyleBackColor = true;
            btnSimpanBuk.Click += btnSimpanBuk_Click;
            // 
            // txtBuku
            // 
            txtBuku.Location = new Point(153, 110);
            txtBuku.Name = "txtBuku";
            txtBuku.Size = new Size(513, 31);
            txtBuku.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 113);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 22;
            label3.Text = "Judul Buku";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 31);
            label4.Name = "label4";
            label4.Size = new Size(85, 38);
            label4.TabIndex = 21;
            label4.Text = "Buku";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(cbStatus);
            tabPage3.Controls.Add(cbBuku);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(btnTambahPem);
            tabPage3.Controls.Add(btnDeletePem);
            tabPage3.Controls.Add(btnUpdatePem);
            tabPage3.Controls.Add(dgvPeminjam);
            tabPage3.Controls.Add(btnSimpanPem);
            tabPage3.Controls.Add(txtNamaPeminjam);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label10);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(787, 547);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Peminjam";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 220);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 42;
            label7.Text = "Status";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Di Pinjam", "Di Kembalikan" });
            cbStatus.Location = new Point(210, 212);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(166, 33);
            cbStatus.TabIndex = 41;
            // 
            // cbBuku
            // 
            cbBuku.FormattingEnabled = true;
            cbBuku.Location = new Point(210, 164);
            cbBuku.Name = "cbBuku";
            cbBuku.Size = new Size(513, 33);
            cbBuku.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 167);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 39;
            label8.Text = "Buku";
            // 
            // btnTambahPem
            // 
            btnTambahPem.Location = new Point(483, 274);
            btnTambahPem.Name = "btnTambahPem";
            btnTambahPem.Size = new Size(112, 34);
            btnTambahPem.TabIndex = 38;
            btnTambahPem.Text = "Tambah";
            btnTambahPem.UseVisualStyleBackColor = true;
            btnTambahPem.Click += btnTambahPem_Click;
            // 
            // btnDeletePem
            // 
            btnDeletePem.Location = new Point(347, 274);
            btnDeletePem.Name = "btnDeletePem";
            btnDeletePem.Size = new Size(112, 34);
            btnDeletePem.TabIndex = 37;
            btnDeletePem.Text = "Delete";
            btnDeletePem.UseVisualStyleBackColor = true;
            btnDeletePem.Click += btnDeletePem_Click;
            // 
            // btnUpdatePem
            // 
            btnUpdatePem.Location = new Point(211, 274);
            btnUpdatePem.Name = "btnUpdatePem";
            btnUpdatePem.Size = new Size(112, 34);
            btnUpdatePem.TabIndex = 36;
            btnUpdatePem.Text = "Update";
            btnUpdatePem.UseVisualStyleBackColor = true;
            btnUpdatePem.Click += btnUpdatePem_Click;
            // 
            // dgvPeminjam
            // 
            dgvPeminjam.AllowUserToOrderColumns = true;
            dgvPeminjam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeminjam.Location = new Point(63, 350);
            dgvPeminjam.Name = "dgvPeminjam";
            dgvPeminjam.RowHeadersWidth = 62;
            dgvPeminjam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeminjam.Size = new Size(614, 225);
            dgvPeminjam.TabIndex = 35;
            dgvPeminjam.CellMouseDoubleClick += dgvPeminjam_CellMouseDoubleClick;
            // 
            // btnSimpanPem
            // 
            btnSimpanPem.Location = new Point(72, 274);
            btnSimpanPem.Name = "btnSimpanPem";
            btnSimpanPem.Size = new Size(112, 34);
            btnSimpanPem.TabIndex = 34;
            btnSimpanPem.Text = "Simpan";
            btnSimpanPem.UseVisualStyleBackColor = true;
            btnSimpanPem.Click += btnSimpanPem_Click;
            // 
            // txtNamaPeminjam
            // 
            txtNamaPeminjam.Location = new Point(210, 122);
            txtNamaPeminjam.Name = "txtNamaPeminjam";
            txtNamaPeminjam.Size = new Size(513, 31);
            txtNamaPeminjam.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(63, 122);
            label9.Name = "label9";
            label9.Size = new Size(141, 25);
            label9.TabIndex = 32;
            label9.Text = "Nama Peminjam";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(52, 40);
            label10.Name = "label10";
            label10.Size = new Size(148, 38);
            label10.TabIndex = 31;
            label10.Text = "Peminjam";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(691, 12);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 37);
            btnKembali.TabIndex = 1;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(249, 12);
            label11.Name = "label11";
            label11.Size = new Size(279, 48);
            label11.TabIndex = 2;
            label11.Text = "PEMINJAMAN";
            // 
            // Peminjaman
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 609);
            Controls.Add(label11);
            Controls.Add(btnKembali);
            Controls.Add(tabControl1);
            Name = "Peminjaman";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Peminjaman";
            Load += Peminjaman_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKategori).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuku).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeminjam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnTambahKat;
        private Button btnDeleteKat;
        private Button bntUpdateKat;
        private DataGridView dgvKategori;
        private Button btnSimpanKat;
        private TextBox txtKategori;
        private Label label2;
        private Label label1;
        private TextBox txtPenulis;
        private Label label6;
        private ComboBox cbKategori;
        private Label label5;
        private Button btnTambahBuk;
        private Button btnDeleteBuk;
        private Button btnUpdateBuk;
        private DataGridView dgvBuku;
        private Button btnSimpanBuk;
        private TextBox txtBuku;
        private Label label3;
        private Label label4;
        private TabPage tabPage3;
        private ComboBox cbBuku;
        private Button btnTambahPem;
        private Button btnDeletePem;
        private Button btnUpdatePem;
        private DataGridView dgvPeminjam;
        private Button btnSimpanPem;
        private TextBox txtNamaPeminjam;
        private Label label9;
        private Label label10;
        private Label label7;
        private ComboBox cbStatus;
        private Label label8;
        private Button btnKembali;
        private Label label11;
    }
}