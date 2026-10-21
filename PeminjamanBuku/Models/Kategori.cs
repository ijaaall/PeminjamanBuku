using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeminjamanBuku.Models
{
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }

        [Required]
        public string NamaKategori { get; set; }

        public ICollection<Buku> Bukus { get; set; }
        //public List<Buku> Bukus { get; set; } = new List<Buku>();
    }
}
