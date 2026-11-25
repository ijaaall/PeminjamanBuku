using Microsoft.EntityFrameworkCore;
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
    public partial class UCPetugas : UserControl
    {
        public int PetugasId = 0;
        public UCPetugas()
        {
            InitializeComponent();
        }

        private async Task loadPetugas()
        {
            using (var context = new AppDbContext())
            {
                dgvPetugas.DataSource = await context.Petugas.Select(p => new
                {
                    NamaPetugas = p.NamaPetugas,
                    Username = p.Username,
                    Password = p.Password,
                    Jabatan = p.Jabatan,
                }).ToListAsync();
            }
        }

        private bool validate()
        {
            errorProviderPetugas.Clear();
            if (string.IsNullOrWhiteSpace(txtNamaPetugas.Text))
            {
                errorProviderPetugas.SetError(txtNamaPetugas,"Nama Petugas tidak boleh kosong");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProviderPetugas.SetError(txtUsername,"Username tidak boleh kosong");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProviderPetugas.SetError(txtPassword,"Password tidak boleh kosong");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtJabatan.Text))
            {
                errorProviderPetugas.SetError(txtJabatan,"Jabatan tidak boleh kosong");
                return false;
            }
            return true;
        }

        private void clear()
        {
            txtNamaPetugas.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtJabatan.Text = "";
        }

        private async void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!validate()) return;

            using (var context = new AppDbContext())
            {
                var petugas = new Petugas
                {
                    NamaPetugas = txtNamaPetugas.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Jabatan = txtJabatan.Text
                };

                context.Petugas.Add(petugas);
                await context.SaveChangesAsync();
                MessageBox.Show("data berhasil di simpan");
                await loadPetugas();
            }
        }

        private async void dgvPetugas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (var context = new AppDbContext())
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {

                        DataGridViewRow row = dgvPetugas.Rows[e.RowIndex];
                        txtNamaPetugas.Text = row.Cells["NamaPetugas"].Value.ToString();
                        txtUsername.Text = row.Cells["Username"].Value.ToString();
                        txtPassword.Text = row.Cells["Password"].Value.ToString();
                        txtJabatan.Text = row.Cells["Jabatan"].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!validate()) return;

            using (var context = new AppDbContext())
            {
                if (dgvPetugas.CurrentRow == null)
                {
                    MessageBox.Show("pilih data terlebih dahulu");
                    return;
                }

                int petugasUp = (int)dgvPetugas.CurrentRow.Cells["PetugasId"].Value;

                try
                {
                    var petugas = await context.Petugas.FindAsync(petugasUp);
                    if (petugas == null)
                    {
                        MessageBox.Show("data tidak ditemukan");
                        return;
                    }

                    DialogResult result = MessageBox.Show("update data ini", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        await context.SaveChangesAsync();
                        MessageBox.Show("data berhasil di update");
                        await loadPetugas();
                        clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void btnHapus_Click(object sender, EventArgs e)
        {
            if (!validate()) return;

            using (var context = new AppDbContext())
            {
                if (dgvPetugas.CurrentRow == null)
                {
                    MessageBox.Show("pilih data terlebih dahulu");
                    return;
                }

                int petugasUp = (int)dgvPetugas.CurrentRow.Cells["PetugasId"].Value;

                try
                {
                    var petugas = await context.Petugas.FindAsync(petugasUp);
                    if (petugas == null)
                    {
                        MessageBox.Show("data tidak ditemukan");
                        return;
                    }

                    DialogResult result = MessageBox.Show("hapus data ini", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        context.Petugas.Remove(petugas);
                        await context.SaveChangesAsync();
                        MessageBox.Show("data berhasil di hapus");
                        await loadPetugas();
                        clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private async void UCPetugas_Load(object sender, EventArgs e)
        {
            await loadPetugas();
        }
    }
}
