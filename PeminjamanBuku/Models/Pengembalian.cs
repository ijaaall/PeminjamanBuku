using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeminjamanBuku.Models
{
    public class Pengembalian
    {
        [Key]
        public int PengembalianId { get; set; }

        [ForeignKey("PeminjamanId")]
        public Peminjam Peminjam { get; set; }

        [Required]
        public DateTime TanggalKembali { get; set; }

        [Required]
        public int TerlambatHari { get; set; }

        public int Denda
        {
            get => TerlambatHari * 1000;
            private set { }
        }
    }
}
