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
            label1 = new Label();
            btnPinjam = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 112);
            label1.Name = "label1";
            label1.Size = new Size(698, 38);
            label1.TabIndex = 0;
            label1.Text = "SELAMAT DATANG DI APLIKASI PERPUSTAKAAN";
            // 
            // btnPinjam
            // 
            btnPinjam.Location = new Point(605, 187);
            btnPinjam.Name = "btnPinjam";
            btnPinjam.Size = new Size(138, 58);
            btnPinjam.TabIndex = 1;
            btnPinjam.Text = "Pinjam";
            btnPinjam.UseVisualStyleBackColor = true;
            btnPinjam.Click += btnPinjam_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPinjam);
            Controls.Add(label1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPinjam;
    }
}