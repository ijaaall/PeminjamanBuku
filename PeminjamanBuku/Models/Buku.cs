using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PeminjamanBuku.Models
{
    public class Buku
    {
        [Key]
        public int BukuId { get; set; }

        [Required]
        [StringLength(20)]
        public string KodeBuku { get; set; } = string.Empty;

        [Required]
        [StringLength(150)]
        public string JudulBuku { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Penulis { get; set; } = string.Empty;

        [Required]
        public int Stok { get; set; }

        public List<Peminjam> Peminjams { get; set; } = new List<Peminjam>();

    }
}
