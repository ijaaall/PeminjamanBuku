namespace PeminjamanBuku
{
    partial class FormRegister
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
            label4 = new Label();
            lblLogin = new LinkLabel();
            txtUsername = new TextBox();
            label3 = new Label();
            btnRegister = new Button();
            txtNamaPetugas = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cbJabatan = new ComboBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 448);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 15;
            label4.Text = "Sudah Punya Akun?";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(270, 448);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(56, 25);
            lblLogin.TabIndex = 14;
            lblLogin.TabStop = true;
            lblLogin.Text = "Login";
            lblLogin.LinkClicked += lblLogin_LinkClicked;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(162, 202);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(274, 31);
            txtUsername.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 202);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 12;
            label3.Text = "Username";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(324, 357);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 48);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtNamaPetugas
            // 
            txtNamaPetugas.Location = new Point(162, 161);
            txtNamaPetugas.Name = "txtNamaPetugas";
            txtNamaPetugas.Size = new Size(274, 31);
            txtNamaPetugas.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 161);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 9;
            label2.Text = "Nama Petugas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 23);
            label1.Name = "label1";
            label1.Size = new Size(212, 54);
            label1.TabIndex = 8;
            label1.Text = "REGISTER";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(162, 245);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(274, 31);
            txtPassword.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 248);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 16;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 298);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 18;
            label6.Text = "Jabatan";
            // 
            // cbJabatan
            // 
            cbJabatan.FormattingEnabled = true;
            cbJabatan.Items.AddRange(new object[] { "Kepala Perpustakaan", "Staff", "Perpustakawan" });
            cbJabatan.Location = new Point(162, 298);
            cbJabatan.Name = "cbJabatan";
            cbJabatan.Size = new Size(274, 33);
            cbJabatan.TabIndex = 19;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 501);
            Controls.Add(cbJabatan);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblLogin);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(btnRegister);
            Controls.Add(txtNamaPetugas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private LinkLabel lblLogin;
        private TextBox txtUsername;
        private Label label3;
        private Button btnRegister;
        private TextBox txtNamaPetugas;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private Label label5;
        private Label label6;
        private ComboBox cbJabatan;
    }
}