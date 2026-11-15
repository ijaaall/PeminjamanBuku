namespace PeminjamanBuku
{
    partial class UCBuku
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtKodeBuku = new TextBox();
            txtJudulBuku = new TextBox();
            label3 = new Label();
            txtPenulis = new TextBox();
            label4 = new Label();
            txtStok = new TextBox();
            label5 = new Label();
            btnSimpan = new Button();
            dgvBuku = new DataGridView();
            btnUpdate = new Button();
            btnHapus = new Button();
            btnBatal = new Button();
            errorProviderBuku = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvBuku).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderBuku).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 36);
            label1.Name = "label1";
            label1.Size = new Size(93, 38);
            label1.TabIndex = 0;
            label1.Text = "BUKU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 133);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Kode Buku";
            // 
            // txtKodeBuku
            // 
            txtKodeBuku.Location = new Point(160, 133);
            txtKodeBuku.Name = "txtKodeBuku";
            txtKodeBuku.PlaceholderText = "Contoh: BK-001";
            txtKodeBuku.Size = new Size(214, 31);
            txtKodeBuku.TabIndex = 2;
            // 
            // txtJudulBuku
            // 
            txtJudulBuku.Location = new Point(160, 182);
            txtJudulBuku.Name = "txtJudulBuku";
            txtJudulBuku.Size = new Size(214, 31);
            txtJudulBuku.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 182);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 3;
            label3.Text = "Judul Buku";
            // 
            // txtPenulis
            // 
            txtPenulis.Location = new Point(160, 235);
            txtPenulis.MaxLength = 255;
            txtPenulis.Name = "txtPenulis";
            txtPenulis.Size = new Size(214, 31);
            txtPenulis.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 235);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 5;
            label4.Text = "Penulis";
            // 
            // txtStok
            // 
            txtStok.Location = new Point(160, 292);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(108, 31);
            txtStok.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 298);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 7;
            label5.Text = "Stok";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(400, 133);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 44);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click_1;
            // 
            // dgvBuku
            // 
            dgvBuku.AllowUserToOrderColumns = true;
            dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuku.Location = new Point(564, 91);
            dgvBuku.Name = "dgvBuku";
            dgvBuku.RowHeadersWidth = 62;
            dgvBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuku.Size = new Size(464, 331);
            dgvBuku.TabIndex = 10;
            dgvBuku.CellMouseDoubleClick += dgvBuku_CellMouseDoubleClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(400, 198);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 44);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(400, 266);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 44);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(400, 328);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(112, 44);
            btnBatal.TabIndex = 13;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // errorProviderBuku
            // 
            errorProviderBuku.ContainerControl = this;
            // 
            // UCBuku
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBatal);
            Controls.Add(btnHapus);
            Controls.Add(btnUpdate);
            Controls.Add(dgvBuku);
            Controls.Add(btnSimpan);
            Controls.Add(txtStok);
            Controls.Add(label5);
            Controls.Add(txtPenulis);
            Controls.Add(label4);
            Controls.Add(txtJudulBuku);
            Controls.Add(label3);
            Controls.Add(txtKodeBuku);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCBuku";
            Size = new Size(1071, 457);
            Load += UCBuku_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuku).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderBuku).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKodeBuku;
        private TextBox txtJudulBuku;
        private Label label3;
        private TextBox txtPenulis;
        private Label label4;
        private TextBox txtStok;
        private Label label5;
        private Button btnSimpan;
        private DataGridView dgvBuku;
        private Button btnUpdate;
        private Button btnHapus;
        private Button btnBatal;
        private ErrorProvider errorProviderBuku;
    }
}
