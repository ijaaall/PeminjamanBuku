using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeminjamanBuku.Models
{
    public class Petugas
    {
        [Key]
        public int PetugasId { get; set; }

        [Required]
        [StringLength(100)]
        public string NamaPetugas { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Jabatan { get; set; } = string.Empty;

        public List<Peminjam> Peminjams { get; set; } = new List<Peminjam>();
    }
}
