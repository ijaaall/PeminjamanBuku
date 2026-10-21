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
        public string JudulBuku { get; set; }

        [Required]
        [StringLength(255)]
        public string Penulis { get; set; }

        public int KategoriId { get; set; }

        [ForeignKey("KategoriId")]
        public Kategori Kategori { get; set; }

        public ICollection<Peminjam> Peminjams { get; set; }
        //public List<Peminjam> Peminjams { get; set; } = new List<Peminjam>();

    }
}
