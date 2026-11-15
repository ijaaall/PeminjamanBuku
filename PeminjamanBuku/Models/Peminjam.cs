using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeminjamanBuku.Models
{
    public enum Status
    {
        DiPinjam = 1,
        DiKembalikan = 2
    }

    public class Peminjam
    {
        [Key]
        public int PeminjamId { get; set; }

        [Required]
        public DateTime TanggalPinjam { get; set; }

        [Required]
        public DateTime TanggalHarusKembali { get; set; }

        // Foreign Key ID eksplisit agar lebih mudah saat simpan data
        public int AnggotaId { get; set; }
        [ForeignKey("AnggotaId")]
        public Anggota Anggota { get; set; }

        public int BukuId { get; set; }
        [ForeignKey("BukuId")]
        public Buku Buku { get; set; }

        public int PetugasId { get; set; }
        [ForeignKey("PetugasId")]
        public Petugas Petugas { get; set; }

        // Disimpan sebagai angka (int) secara default oleh EF Core
        [Required]
        public Status Status { get; set; } = Status.DiPinjam;

        public List<Pengembalian> Pengembalians { get; set; } = new List<Pengembalian>();
    }
}
