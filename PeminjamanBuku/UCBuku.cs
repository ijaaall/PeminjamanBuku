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
    public partial class UCBuku : UserControl
    {
        public int BukuId = 0;
        public UCBuku()
        {
            InitializeComponent();
        }

        private async Task loadBuku()
        {
            using (var context = new AppDbContext())
            {
                dgvBuku.DataSource = await context.Bukus.Select(b => new
                {
                    BukuId = b.BukuId,
                    KodeBuku = b.KodeBuku,
                    JudulBuku = b.JudulBuku,
                    Penulis = b.Penulis,
                    Stok = b.Stok
                }).ToListAsync();
            }
        }

        private bool validate()
        {
            errorProviderBuku.Clear();

            if (string.IsNullOrEmpty(txtKodeBuku.Text))
            {
                errorProviderBuku.SetError(txtKodeBuku, "kode buku tidak boleh kosong");
                return false;
            }
            if (string.IsNullOrEmpty(txtJudulBuku.Text))
            {
                errorProviderBuku.SetError(txtJudulBuku, "judul buku tidak boleh kosong");
                return false;
            }
            if (string.IsNullOrEmpty(txtPenulis.Text))
            {
                errorProviderBuku.SetError(txtPenulis, "penulis tidak boleh kosong");
                return false;
            }
            if (string.IsNullOrEmpty(txtStok.Text))
            {
                errorProviderBuku.SetError(txtStok, "stok tidak boleh kosong");
                return false;
            }

            return true;
        }

        private void clear()
        {
            txtKodeBuku.Text = "";
            txtJudulBuku.Text = "";
            txtPenulis.Text = "";
            txtStok.Text = "";
        }

        private async void UCBuku_Load(object sender, EventArgs e)
        {
            await loadBuku();
        }

        private async void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (!validate())
            {
                return;
            }

            using (var context = new AppDbContext())
            {
                var buku = new Buku
                {
                    KodeBuku = txtKodeBuku.Text,
                    JudulBuku = txtJudulBuku.Text,
                    Penulis = txtPenulis.Text,
                    Stok = Convert.ToInt32(txtStok.Text),
                };

                context.Bukus.Add(buku);
                await context.SaveChangesAsync();
                MessageBox.Show("data berhasil di simpan");
                await loadBuku();
                clear();
            }
        }

        private void dgvBuku_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (var context = new AppDbContext())
            { 
                try
                {
                    if (e.RowIndex >= 0)
                    {

                        DataGridViewRow row = dgvBuku.Rows[e.RowIndex];
                        txtKodeBuku.Text = row.Cells["KodeBuku"].Value.ToString();
                        txtJudulBuku.Text = row.Cells["JudulBuku"].Value.ToString();
                        txtPenulis.Text = row.Cells["Penulis"].Value.ToString();
                        txtStok.Text = row.Cells["Stok"].Value.ToString();
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
            using (var context = new AppDbContext())
            {
                if (dgvBuku.CurrentRow == null)
                {
                    MessageBox.Show("pilih data terlebih dahulu");
                    return;
                }

                if (!validate())
                {
                    return;
                }

                int BukuUp = (int)dgvBuku.CurrentRow.Cells["BukuId"].Value;

                try
                {
                    btnUpdate.Enabled = true;

                    var buku = await context.Bukus.FindAsync(BukuUp);
                    if (buku == null)
                    {
                        MessageBox.Show("data tidak di temukan");
                        return;
                    }

                    buku.KodeBuku = txtKodeBuku.Text.Trim();
                    buku.JudulBuku = txtJudulBuku.Text.Trim();
                    buku.Penulis = txtPenulis.Text.Trim();
                    buku.Stok = Convert.ToInt32(txtStok.Text.Trim());

                    DialogResult result = MessageBox.Show("update data?","confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    { 
                        await context.SaveChangesAsync();
                        MessageBox.Show("data berhasil di update");
                        await loadBuku();
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

        private async void btnHapus_Click(object sender, EventArgs e)
        {
            if (!validate())
            { 
                return;
            }

            using (var context = new AppDbContext())
            {
                if (dgvBuku.CurrentRow == null)
                {
                    MessageBox.Show("pilih data terlebih dahulu");
                    return;
                }

                int BukuDel = (int)dgvBuku.CurrentRow.Cells["BukuId"].Value;

                try
                {
                    var buku = await context.Bukus.FindAsync(BukuDel);
                    if (buku == null)
                    {
                        MessageBox.Show("data tidak di temukan");
                        return;
                    }

                    DialogResult result = MessageBox.Show("Hapus data ini?", "confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    { 
                        context.Bukus.Remove(buku);
                        await context.SaveChangesAsync();
                        MessageBox.Show("data berhasil di hapus");
                        await loadBuku();
                        clear();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
