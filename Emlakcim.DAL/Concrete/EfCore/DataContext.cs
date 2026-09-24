using Emlakcim.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emlakcim.DAL.Concrete.EfCore
{
    internal class DataContext:DbContext //entityFrameworkCore paketinden geliyor.
    {

        //Database bağlantısının tanımlandığı alan.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-58CMK8T\\SQLEXPRESS; Database=MakaanDB; Trusted_Connection=true; TrustServerCertificate=true;");//EntityFrameworkCore.SqlServer paketi
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes  { get; set; }
        public DbSet<ProductDetail> ProductDetail  { get; set; }
        public DbSet<Agency> Agencies  { get; set; }
        public DbSet<District> Districts  { get; set; }
        public DbSet<Slider> Sliders  { get; set; }
    }
}
