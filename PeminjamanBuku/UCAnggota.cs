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
    public partial class UCAnggota : UserControl
    {
        public int AnggotaId = 0;
        public UCAnggota()
        {
            InitializeComponent();
        }

        private async Task loadAnggota()
        {
            using (var context = new AppDbContext())
            {
                dgvAnggota.DataSource = await context.Anggotas.Select(a => new
                {
                    AnggotaId = a.AnggotaId, 
                    Nisn = a.Nisn,
                    NamaAnggota = a.NamaAnggota,
                    JenisKelamin = a.JenisKelamin,
                    Kelas = a.Kelas,
                }).ToListAsync();

                if (dgvAnggota.Columns["AnggotaId"] != null)
                {
                    dgvAnggota.Columns["AnggotaId"].Visible = false;
                }
            }
        }

        private bool validate()
        {
            errorProviderAnggota.Clear();
            if (string.IsNullOrWhiteSpace(txtNisn.Text))
            {
                errorProviderAnggota.SetError(txtNisn,"NISN tidak boleh kosong");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNamaAnggota.Text))
            {
                errorProviderAnggota.SetError(txtNamaAnggota,"Nama Anggota tidak boleh kosong");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbJenisKelamin.Text))
            {
                errorProviderAnggota.SetError(cbJenisKelamin,"Jenis Kelamin tidak boleh kosong");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtKelas.Text))
            {
                errorProviderAnggota.SetError(txtKelas,"Kelas tidak boleh kosong");
                return false;
            }
            return true;
        }

        private void clear()
        {
            txtNisn.Text = "";
            txtNamaAnggota.Text = "";
            cbJenisKelamin.SelectedIndex = -1;
            txtKelas.Text = "";
        }



        private async void UCAnggota_Load(object sender, EventArgs e)
        {
            await loadAnggota();
        }

        private async void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!validate()) return;

            if (cbJenisKelamin.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih jenis kelamin terlebih dahulu!", "Peringatan");
                return;
            }

            using (var context = new AppDbContext())
            {
                var anggota = new Anggota
                {
                    Nisn = txtNisn.Text,
                    NamaAnggota = txtNamaAnggota.Text,
                    JenisKelamin = (JenisKelamin)(cbJenisKelamin.SelectedIndex + 1),
                    Kelas = txtKelas.Text
                };

                context.Anggotas.Add(anggota);
                await context.SaveChangesAsync();
                MessageBox.Show("data berhasil di simpan");
                await loadAnggota();
                clear();
            }
        }

        private async void dgvAnggota_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (var context = new AppDbContext())
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvAnggota.Rows[e.RowIndex];
                    txtNisn.Text = row.Cells["Nisn"].Value.ToString();
                    txtNamaAnggota.Text = row.Cells["NamaAnggota"].Value.ToString();
                    cbJenisKelamin.Text = row.Cells["JenisKelamin"].Value.ToString();
                    txtKelas.Text = row.Cells["Kelas"].Value.ToString();
                }
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!validate()) return;

            using (var context = new AppDbContext())
            {
                if (dgvAnggota.CurrentRow == null)
                {
                    MessageBox.Show("pilih data terlebih dahulu");
                    return;
                }

                int anggotaUp = (int)dgvAnggota.CurrentRow.Cells["AnggotaId"].Value;

                try
                {
                    var anggota = await context.Anggotas.FindAsync(anggotaUp);
                    if (anggota == null)
                    {
                        MessageBox.Show("data tidak ditemukan");
                        return;
                    }

                    DialogResult result = MessageBox.Show("update data ini", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        anggota.Nisn = txtNisn.Text;
                        anggota.NamaAnggota = txtNamaAnggota.Text;
                        anggota.JenisKelamin = (JenisKelamin)(cbJenisKelamin.SelectedIndex + 1);
                        anggota.Kelas = txtKelas.Text;

                        await context.SaveChangesAsync();
                        MessageBox.Show("Data berhasil di-update");
                        await loadAnggota();
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
                if (dgvAnggota.CurrentRow == null)
                {
                    MessageBox.Show("pilih data terlebih dahulu");
                    return;
                }

                int anggotaUp = (int)dgvAnggota.CurrentRow.Cells["AnggotaId"].Value;

                try
                {
                    var anggota = await context.Anggotas.FindAsync(anggotaUp);
                    if (anggota == null)
                    {
                        MessageBox.Show("data tidak ditemukan");
                        return;
                    }

                    DialogResult result = MessageBox.Show("hapus data ini?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        context.Anggotas.Remove(anggota);
                        await context.SaveChangesAsync();
                        MessageBox.Show("data berhasil di hapus");
                        await loadAnggota();
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
    }
}
