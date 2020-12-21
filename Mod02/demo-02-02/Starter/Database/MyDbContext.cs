using Microsoft.EntityFrameworkCore;
using MyFirstE.Models;

namespace MyFirstE.Database {

public class MyDbContext : DbContext
     {
         public DbSet<Product> Products { get; set; }
         public DbSet<Store> Stores { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseSqlServer(@"Server=(localdb)\.;Database=MyFirstEF;Trusted_Connection=True;");
         }
     }




}