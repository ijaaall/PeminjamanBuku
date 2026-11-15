namespace PeminjamanBuku
{
    partial class Dashboard
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
            groupBox1 = new GroupBox();
            btnPengembalian = new Button();
            btnPeminjaman = new Button();
            btnPetugas = new Button();
            label1 = new Label();
            btnAnggota = new Button();
            btnBuku = new Button();
            content = new GroupBox();
            label5 = new Label();
            label3 = new Label();
            lblNama = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            content.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPengembalian);
            groupBox1.Controls.Add(btnPeminjaman);
            groupBox1.Controls.Add(btnPetugas);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAnggota);
            groupBox1.Controls.Add(btnBuku);
            groupBox1.Location = new Point(3, -2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 451);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnPengembalian
            // 
            btnPengembalian.Location = new Point(9, 311);
            btnPengembalian.Name = "btnPengembalian";
            btnPengembalian.Size = new Size(157, 40);
            btnPengembalian.TabIndex = 5;
            btnPengembalian.Text = "Pengembalian";
            btnPengembalian.UseVisualStyleBackColor = true;
            // 
            // btnPeminjaman
            // 
            btnPeminjaman.Location = new Point(9, 251);
            btnPeminjaman.Name = "btnPeminjaman";
            btnPeminjaman.Size = new Size(157, 40);
            btnPeminjaman.TabIndex = 4;
            btnPeminjaman.Text = "Peminjaman";
            btnPeminjaman.UseVisualStyleBackColor = true;
            // 
            // btnPetugas
            // 
            btnPetugas.Location = new Point(9, 192);
            btnPetugas.Name = "btnPetugas";
            btnPetugas.Size = new Size(157, 40);
            btnPetugas.TabIndex = 3;
            btnPetugas.Text = "Petugas";
            btnPetugas.UseVisualStyleBackColor = true;
            btnPetugas.Click += btnPetugas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 27);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 2;
            label1.Text = "Menu";
            // 
            // btnAnggota
            // 
            btnAnggota.Location = new Point(9, 132);
            btnAnggota.Name = "btnAnggota";
            btnAnggota.Size = new Size(157, 40);
            btnAnggota.TabIndex = 1;
            btnAnggota.Text = "Anggota";
            btnAnggota.UseVisualStyleBackColor = true;
            btnAnggota.Click += btnAnggota_Click;
            // 
            // btnBuku
            // 
            btnBuku.Location = new Point(9, 77);
            btnBuku.Name = "btnBuku";
            btnBuku.Size = new Size(157, 40);
            btnBuku.TabIndex = 0;
            btnBuku.Text = "Buku";
            btnBuku.UseVisualStyleBackColor = true;
            btnBuku.Click += btnBuku_Click;
            // 
            // content
            // 
            content.Controls.Add(label5);
            content.Controls.Add(label3);
            content.Controls.Add(lblNama);
            content.Controls.Add(label4);
            content.Controls.Add(label2);
            content.Location = new Point(191, 3);
            content.Name = "content";
            content.Size = new Size(1085, 596);
            content.TabIndex = 1;
            content.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(498, 114);
            label5.Name = "label5";
            label5.Size = new Size(61, 48);
            label5.TabIndex = 4;
            label5.Text = "DI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 237);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 3;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(584, 77);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(0, 38);
            lblNama.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(332, 162);
            label4.Name = "label4";
            label4.Size = new Size(434, 48);
            label4.TabIndex = 1;
            label4.Text = "PERPUSTAKAAN NUSA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(360, 82);
            label2.Name = "label2";
            label2.Size = new Size(210, 32);
            label2.TabIndex = 0;
            label2.Text = "SELAMAT DATANG";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 611);
            Controls.Add(content);
            Controls.Add(groupBox1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            content.ResumeLayout(false);
            content.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnBuku;
        private Button btnPengembalian;
        private Button btnPeminjaman;
        private Button btnPetugas;
        private Label label1;
        private Button btnAnggota;
        private GroupBox content;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label lblNama;
    }
}