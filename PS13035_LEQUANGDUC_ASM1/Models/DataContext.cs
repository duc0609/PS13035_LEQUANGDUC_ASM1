using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PS13035_LEQUANGDUC_ASM1.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        public DbSet<MonAn> MonAns { get; set; } 
        public DbSet<Nguoidung> Nguoidungs { get; set; }
        public DbSet<Donhang> Donhangs { get; set; }
        public DbSet<Khachhang> Khachhangs { get; set; }
        public DbSet<DonhangChitiet> DonhangChitiets { get; set; }
    }

}

