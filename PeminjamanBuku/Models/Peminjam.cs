using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

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

        [ForeignKey("AnggotaId")]
        public Anggota Anggota { get; set; }

        [ForeignKey("BukuId")]
        public Buku Buku { get; set; }

        [ForeignKey("PetugasId")]
        public Petugas Petugas { get; set; }

        [Required]
        public Status Status { get; set; }

        public List<Pengembalian> Pengembalians { get; set; } = new List<Pengembalian>();
    }
}
