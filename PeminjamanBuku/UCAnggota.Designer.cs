namespace PeminjamanBuku
{
    partial class UCAnggota
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
            txtNisn = new TextBox();
            btnSimpan = new Button();
            dgvAnggota = new DataGridView();
            txtNamaAnggota = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtKelas = new TextBox();
            label5 = new Label();
            cbJenisKelamin = new ComboBox();
            btnBatal = new Button();
            btnHapus = new Button();
            btnUpdate = new Button();
            errorProviderAnggota = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvAnggota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAnggota).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 0;
            label1.Text = "ANGGOTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 118);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 1;
            label2.Text = "NISN";
            // 
            // txtNisn
            // 
            txtNisn.Location = new Point(173, 118);
            txtNisn.MaxLength = 10;
            txtNisn.Name = "txtNisn";
            txtNisn.Size = new Size(220, 31);
            txtNisn.TabIndex = 2;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(420, 118);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 41);
            btnSimpan.TabIndex = 3;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // dgvAnggota
            // 
            dgvAnggota.AllowUserToOrderColumns = true;
            dgvAnggota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnggota.Location = new Point(560, 100);
            dgvAnggota.Name = "dgvAnggota";
            dgvAnggota.RowHeadersWidth = 62;
            dgvAnggota.Size = new Size(440, 225);
            dgvAnggota.TabIndex = 4;
            dgvAnggota.CellMouseDoubleClick += dgvAnggota_CellMouseDoubleClick;
            // 
            // txtNamaAnggota
            // 
            txtNamaAnggota.Location = new Point(173, 169);
            txtNamaAnggota.Name = "txtNamaAnggota";
            txtNamaAnggota.Size = new Size(220, 31);
            txtNamaAnggota.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 169);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 5;
            label3.Text = "Nama Anggota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 218);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 7;
            label4.Text = "Jenis Kelamin";
            // 
            // txtKelas
            // 
            txtKelas.Location = new Point(173, 264);
            txtKelas.MaxLength = 20;
            txtKelas.Name = "txtKelas";
            txtKelas.Size = new Size(220, 31);
            txtKelas.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 264);
            label5.Name = "label5";
            label5.Size = new Size(52, 25);
            label5.TabIndex = 9;
            label5.Text = "Kelas";
            // 
            // cbJenisKelamin
            // 
            cbJenisKelamin.FormattingEnabled = true;
            cbJenisKelamin.Items.AddRange(new object[] { "Laki-Laki", "Perempuan" });
            cbJenisKelamin.Location = new Point(173, 218);
            cbJenisKelamin.Name = "cbJenisKelamin";
            cbJenisKelamin.Size = new Size(220, 33);
            cbJenisKelamin.TabIndex = 11;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(420, 308);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(112, 44);
            btnBatal.TabIndex = 16;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(420, 246);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 44);
            btnHapus.TabIndex = 15;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(420, 178);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 44);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // errorProviderAnggota
            // 
            errorProviderAnggota.ContainerControl = this;
            // 
            // UCAnggota
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBatal);
            Controls.Add(btnHapus);
            Controls.Add(btnUpdate);
            Controls.Add(cbJenisKelamin);
            Controls.Add(txtKelas);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNamaAnggota);
            Controls.Add(label3);
            Controls.Add(dgvAnggota);
            Controls.Add(btnSimpan);
            Controls.Add(txtNisn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCAnggota";
            Size = new Size(1033, 426);
            Load += UCAnggota_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnggota).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAnggota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNisn;
        private Button btnSimpan;
        private DataGridView dgvAnggota;
        private TextBox txtNamaAnggota;
        private Label label3;
        private Label label4;
        private TextBox txtKelas;
        private Label label5;
        private ComboBox cbJenisKelamin;
        private Button btnBatal;
        private Button btnHapus;
        private Button btnUpdate;
        private ErrorProvider errorProviderAnggota;
    }
}
