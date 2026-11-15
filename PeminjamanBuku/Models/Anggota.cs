using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeminjamanBuku.Models
{
    public enum JenisKelamin
    { 
        LakiLaki = 1,
        Perempuan = 2
    }

    public class Anggota
    {
        [Key]
        public int AnggotaId { get; set; }

        [Required]
        [StringLength(10)]
        public string Nisn { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string NamaAnggota { get; set; } = string.Empty;

        [Required]
        public JenisKelamin JenisKelamin { get; set; }

        [Required]
        [StringLength(20)]
        public string Kelas { get; set; } = string.Empty;

        public List<Peminjam> Peminjams { get; set; } = new List<Peminjam>();
    }
}
