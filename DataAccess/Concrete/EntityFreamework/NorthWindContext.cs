using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFreamework
{
    // DB tabloları ile proje classlarını bağlar.
    public class NorthWindContext : DbContext
    {
        //Projemin hangi DB ile ikişkili oldugunu yazacagım yer.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Northwind; Trusted_Connection=True");
        }

            public DbSet<Product> Products { get; set; }
            public DbSet<Category> categories { get; set; }
            public DbSet<Customer> Customers { get; set; }

            public DbSet<Order> orders { get; set; }
        }
    }
    

