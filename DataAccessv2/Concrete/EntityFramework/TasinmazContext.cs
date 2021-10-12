using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{       
    //Contex: Db tabloları ile proje classlarını bağlamaktır.
    public class TasinmazContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost; port=5432;Database=tasinmaz; username=postgres;password=postgres");

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public DbSet<Provinces> Provinces { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Neighbourhoods> Neighbourhoods { get; set; }
        public DbSet<Tasinmaz> Tasinmaz { get; set; }



    }
}
