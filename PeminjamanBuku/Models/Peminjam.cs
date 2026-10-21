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
    public class Peminjam
    {
        [Key]
        public int PeminjamId { get; set; }

        [Required]
        [StringLength(255)]
        public string NamaPeminjam { get; set; }
        public string Status { get; set; }

        [Required]
        public int BukuId { get; set; }
        [ForeignKey("BukuId")]
        public Buku Buku { get; set; }

        //public ICollection<Buku> Bukus { get; set; }
    }
}
