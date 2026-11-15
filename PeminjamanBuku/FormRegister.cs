using PeminjamanBuku.Data;
using PeminjamanBuku.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeminjamanBuku
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var petugas = new Petugas
                {
                    NamaPetugas = txtNamaPetugas.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Jabatan = cbJabatan.Text,
                };

                context.Petugas.Add(petugas);
                await context.SaveChangesAsync();
                MessageBox.Show("berhasil membuat data baru");

                new FormLogin().Show();
                this.Hide();
            }
        }
    }
}
