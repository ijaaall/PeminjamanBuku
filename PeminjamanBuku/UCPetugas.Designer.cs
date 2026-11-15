namespace PeminjamanBuku
{
    partial class UCPetugas
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
            label1 = new Label();
            label2 = new Label();
            txtNamaPetugas = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            btnSimpan = new Button();
            dgvPetugas = new DataGridView();
            txtJabatan = new TextBox();
            label5 = new Label();
            btnBatal = new Button();
            btnHapus = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPetugas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 0;
            label1.Text = "PETUGAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 110);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 1;
            label2.Text = "Nama Petugas";
            // 
            // txtNamaPetugas
            // 
            txtNamaPetugas.Location = new Point(182, 107);
            txtNamaPetugas.Name = "txtNamaPetugas";
            txtNamaPetugas.Size = new Size(183, 31);
            txtNamaPetugas.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(182, 156);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(183, 31);
            txtUsername.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 159);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(182, 207);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(183, 31);
            txtPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 210);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(382, 110);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 41);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // dgvPetugas
            // 
            dgvPetugas.AllowUserToOrderColumns = true;
            dgvPetugas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPetugas.Location = new Point(516, 107);
            dgvPetugas.Name = "dgvPetugas";
            dgvPetugas.RowHeadersWidth = 62;
            dgvPetugas.Size = new Size(430, 225);
            dgvPetugas.TabIndex = 8;
            dgvPetugas.CellMouseDoubleClick += dgvPetugas_CellMouseDoubleClick;
            // 
            // txtJabatan
            // 
            txtJabatan.Location = new Point(182, 254);
            txtJabatan.Name = "txtJabatan";
            txtJabatan.Size = new Size(183, 31);
            txtJabatan.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 257);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 9;
            label5.Text = "Jabatan";
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(382, 298);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(112, 44);
            btnBatal.TabIndex = 19;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(382, 236);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 44);
            btnHapus.TabIndex = 18;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(382, 168);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 44);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UCPetugas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBatal);
            Controls.Add(btnHapus);
            Controls.Add(btnUpdate);
            Controls.Add(txtJabatan);
            Controls.Add(label5);
            Controls.Add(dgvPetugas);
            Controls.Add(btnSimpan);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtNamaPetugas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCPetugas";
            Size = new Size(971, 422);
            Load += UCPetugas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPetugas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNamaPetugas;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private Button btnSimpan;
        private DataGridView dgvPetugas;
        private TextBox txtJabatan;
        private Label label5;
        private Button btnBatal;
        private Button btnHapus;
        private Button btnUpdate;
    }
}
