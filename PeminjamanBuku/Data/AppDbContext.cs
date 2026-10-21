using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PeminjamanBuku.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeminjamanBuku.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=IJAAALL\\SQLEXPRESS;Database=PeminjamaBukuDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Buku> Bukus { get; set; }
        public DbSet<Peminjam> Peminjams { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Operator> Operators { get; set; }
        public DbSet<Role> Roles { get; set; }

        //session tidak di DbSet kan
        //public DbSet<Session> Sessions { get; set; }
    }
}
