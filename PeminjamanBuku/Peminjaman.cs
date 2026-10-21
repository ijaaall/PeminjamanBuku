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
    public partial class Peminjaman : Form
    {
        public int IdKategori = 0;
        public int IdBuku = 0;
        public int IdPeminjam = 0;
        public Peminjaman()
        {
            InitializeComponent();
        }

        public async Task LoadKategori()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var kategori = await context.Kategoris.Select(k => new
                    {
                        KategoriId = k.KategoriId,
                        NamaKategori = k.NamaKategori,
                    }).ToListAsync();

                    dgvKategori.DataSource = kategori;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async Task LoadBuku()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var buku = await context.Bukus.Select(b => new
                    {
                        IdBuku = b.BukuId,
                        JudulBuku = b.JudulBuku,
                        Penulis = b.Penulis,
                        NamaKategori = b.Kategori.NamaKategori,
                    }).ToListAsync();

                    var kategori = await context.Kategoris.Select(k => new
                    {
                        IdKategori = k.KategoriId,
                        NamaKategori = k.NamaKategori,
                    }).ToListAsync();

                    cbKategori.ValueMember = "IdKategori";
                    cbKategori.DisplayMember = "NamaKategori";
                    cbKategori.DataSource = kategori;
                    cbKategori.SelectedIndex = -1;

                    dgvBuku.DataSource = buku;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task LoadPeminjam()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var peminjam = await context.Peminjams.Include(p => p.Buku).Select(p => new
                    {
                        IdPeminjam = p.PeminjamId,
                        NamaPeminjam = p.NamaPeminjam,
                        NamaBuku = p.Buku.JudulBuku,
                        Status = p.Status,
                    }).ToListAsync();

                    var Buku = await context.Bukus.Select(b => new
                    {
                        Idbuku = b.BukuId,
                        JudulBuku = b.JudulBuku,
                    }).ToListAsync();
                    cbBuku.ValueMember = "IdBuku";
                    cbBuku.DisplayMember = "JudulBuku";
                    cbBuku.DataSource = Buku;
                    cbBuku.SelectedIndex = -1;

                    dgvPeminjam.DataSource = peminjam;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void Peminjaman_Load(object sender, EventArgs e)
        {
            await LoadBuku();
            await LoadKategori();
            await LoadPeminjam();
        }

        private async void btnSimpanKat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategori.Text))
            {
                MessageBox.Show("data tidak boleh kosong");
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    var kategoriBaru = new Kategori
                    {
                        NamaKategori = txtKategori.Text,
                    };
                    context.Kategoris.Add(kategoriBaru);

                    await context.SaveChangesAsync();

                    //bntUpdateKat.Enabled = false;
                }
                MessageBox.Show("data di simpan");
                await LoadKategori();
                txtKategori.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTambahKat_Click(object sender, EventArgs e)
        {
            txtKategori.Text = "";
            btnSimpanKat.Enabled = true;
        }

        private async void bntUpdateKat_Click(object sender, EventArgs e)
        {
            if (dgvKategori.CurrentRow == null)
            {
                MessageBox.Show("pilih data terlebih dahulu");
                return;
            }

            int kategoriUp = (int)dgvKategori.CurrentRow.Cells["KategoriId"].Value;

            try
            {
                using (var context = new AppDbContext())
                {
                    var kategori = await context.Kategoris.FindAsync(kategoriUp);

                    if (kategori == null)
                    {
                        MessageBox.Show("data tidak di temukan");
                        return;
                    }
                    kategori.NamaKategori = txtKategori.Text.Trim();

                    await context.SaveChangesAsync();
                }
                MessageBox.Show("berhasil update");
                await LoadKategori();
                txtKategori.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnDeleteKat_Click(object sender, EventArgs e)
        {
            if (dgvKategori.CurrentRow == null)
            {
                MessageBox.Show("pilih data terlebih dahulu");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKategori.Text))
            {
                MessageBox.Show("pilih data terlebih dahulu");
                return;
            }

            int kategoriDel = (int)dgvKategori.CurrentRow.Cells["KategoriId"].Value;

            try
            {
                using (var context = new AppDbContext())
                {
                    var kategori = await context.Kategoris.FindAsync(kategoriDel);

                    if (kategori == null)
                    {
                        MessageBox.Show("data tidak di temukan");
                        return;
                    }
                    context.Kategoris.Remove(kategori);
                    await context.SaveChangesAsync();

                    btnSimpanKat.Enabled = true;
                }
                MessageBox.Show("berhasil hapus");
                await LoadKategori();
                txtKategori.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dgvKategori_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                DataGridViewRow row = dgvKategori.Rows[e.RowIndex];
                txtKategori.Text = row.Cells["NamaKategori"].Value.ToString();

                btnSimpanKat.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSimpanBuk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuku.Text) || txtPenulis.Text == null)
            {
                MessageBox.Show("data tidak boleh kosong");
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    var newbuku = new Buku
                    {
                        JudulBuku = txtBuku.Text,
                        Penulis = txtPenulis.Text,
                        KategoriId = Convert.ToInt32(cbKategori.SelectedValue),
                    };
                    context.Bukus.Add(newbuku);
                    await context.SaveChangesAsync();
                }
                MessageBox.Show("data berhasil di simpan");
                await LoadBuku();
                txtBuku.Text = "";
                txtPenulis.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnUpdateBuk_Click(object sender, EventArgs e)
        {
            if (dgvBuku.CurrentRow == null)
            {
                MessageBox.Show("pilih data terlebih dahulu");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBuku.Text) || txtPenulis.Text == null)
            {
                MessageBox.Show("data tidak boleh kosong");
                return;
            }

            int bukuUp = (int)dgvBuku.CurrentRow.Cells["IdBuku"].Value;
            int kategori = (int)cbKategori.SelectedValue;

            try
            {
                using (var context = new AppDbContext())
                {
                    var buku = await context.Bukus.FindAsync(bukuUp);

                    if (buku == null)
                    {
                        MessageBox.Show("data tidak di temukan");
                        return;
                    }
                    buku.JudulBuku = txtBuku.Text.Trim();
                    buku.Penulis = txtPenulis.Text.Trim();
                    buku.KategoriId = kategori;

                    await context.SaveChangesAsync();

                    btnSimpanBuk.Enabled = true;
                }
                MessageBox.Show("berhasil update");
                await LoadBuku();
                txtBuku.Text = "";
                txtPenulis.Text = "";

                btnSimpanBuk.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnDeleteBuk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuku.Text) || txtPenulis.Text == null)
            {
                MessageBox.Show("pilih data terlebih dahulu");
                return;
            }

            int bukuDel = (int)dgvBuku.CurrentRow.Cells["IdBuku"].Value;

            DialogResult dialog = MessageBox.Show("hapus data ini?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No) return;
            try
            {
                using (var context = new AppDbContext())
                {
                    var buku = await context.Bukus.FindAsync(bukuDel);

                    if (buku == null)
                    {
                        MessageBox.Show("data tidak di temukan");
                        return;
                    }

                    context.Bukus.Remove(buku);
                    await context.SaveChangesAsync();

                    btnSimpanBuk.Enabled = true;
                }
                MessageBox.Show("data berhasil di hapus");
                await LoadBuku();
                txtBuku.Text = "";
                txtPenulis.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTambahBuk_Click(object sender, EventArgs e)
        {
            txtBuku.Text = "";
            txtPenulis.Text = "";
            cbKategori.SelectedIndex = -1;

            btnSimpanBuk.Enabled = true;
        }

        private async void dgvBuku_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                DataGridViewRow row = dgvBuku.Rows[e.RowIndex];
                txtBuku.Text = row.Cells["JudulBuku"].Value.ToString();
                txtPenulis.Text = row.Cells["Penulis"].Value.ToString();
                cbKategori.Text = row.Cells["NamaKategori"].Value.ToString();

                btnSimpanBuk.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSimpanPem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var newPeminjam = new Peminjam
                    {
                        NamaPeminjam = txtNamaPeminjam.Text,
                        BukuId = Convert.ToInt32(cbBuku.SelectedValue),
                        Status = cbStatus.Text,
                    };
                    context.Peminjams.Add(newPeminjam);
                    await context.SaveChangesAsync();

                    btnSimpanPem.Enabled = true;
                }
                MessageBox.Show("data di simpan");
                await LoadPeminjam();
                txtNamaPeminjam.Text = "";
                cbStatus.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dgvPeminjam_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                DataGridViewRow row = dgvPeminjam.Rows[e.RowIndex];
                txtNamaPeminjam.Text = row.Cells["NamaPeminjam"].Value.ToString();
                cbStatus.Text = row.Cells["Status"].Value.ToString();
                cbBuku.Text = row.Cells["NamaBuku"].Value.ToString();

                btnSimpanPem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnUpdatePem_Click(object sender, EventArgs e)
        {
            if (dgvPeminjam.CurrentRow == null)
            {
                MessageBox.Show("pilih data terlebih dahulu");
                return;
            }

            int peminjamUp = (int)dgvPeminjam.CurrentRow.Cells["IdPeminjam"].Value;
            int buku = (int)cbBuku.SelectedValue;

            try
            {
                using (var context = new AppDbContext())
                {
                    var peminjam = await context.Peminjams.FindAsync(peminjamUp);

                    if (peminjam == null)
                    {
                        MessageBox.Show("data tidak ditemukan");
                        return;
                    }

                    peminjam.NamaPeminjam = txtNamaPeminjam.Text.Trim();
                    peminjam.BukuId = buku;
                    peminjam.Status = cbStatus.Text.Trim();

                    await context.SaveChangesAsync();
                    btnSimpanPem.Enabled = true;
                }
                MessageBox.Show("berhasil update");
                await LoadPeminjam();
                txtNamaPeminjam.Text = "";
                cbStatus.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnDeletePem_Click(object sender, EventArgs e)
        {
            if (dgvPeminjam.CurrentRow == null)
            {
                MessageBox.Show("pilih data terlebih dahulu");
                return;
            }

            int peminjamDel = (int)dgvPeminjam.CurrentRow.Cells["Idbuku"].Value;

            try
            {
                using (var context = new AppDbContext())
                {
                    var peminjam = await context.Peminjams.FindAsync(peminjamDel);

                    await context.SaveChangesAsync();

                    btnSimpanPem.Enabled = true;
                }
                MessageBox.Show("data berhasil di delete");
                await LoadPeminjam();
                txtNamaPeminjam.Text = "";
                cbBuku.SelectedIndex = -1;
                cbStatus.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTambahPem_Click(object sender, EventArgs e)
        {
            txtNamaPeminjam.Text = "";
            cbBuku.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;

            btnSimpanPem.Enabled = true;
        }

        private async void btnKembali_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }
    }
}
