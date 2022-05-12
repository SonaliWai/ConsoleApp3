using ConsoleApp3.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class SampleStoreContext : DbContext
    {

        
        public DbSet<Person> Persons { get; set; }
        //public DbSet<BrandProductInfoResult> brandInfo { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brands> brands { get; set; }
        public DbSet<Categories> categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=WAIANGDESK12;Initial Catalog=SampleStore;Integrated Security=True");
        }

       
    }

