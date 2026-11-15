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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void btnPinjam_Click(object sender, EventArgs e)
        {

        }

        private void loadControl(UserControl uc)
        {
            content.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            content.Controls.Add(uc);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblNama.Text += "" + Session.NamaPetugas;
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            loadControl(new UCBuku());
        }

        private void btnAnggota_Click(object sender, EventArgs e)
        {
            loadControl(new UCAnggota());
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            loadControl(new UCPetugas());
        }
    }
}
