using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeminjamanBuku.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        public string NamaRole { get; set; }

        public List<Operator> Operators { get; set; } = new List<Operator>();
    }
}
