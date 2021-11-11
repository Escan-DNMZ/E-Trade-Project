using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ComputerShop.Data.Models
{
    public class Context : DbContext
    {
           protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
               optionsBuilder.UseMySql(@"server=localhost;port=3306;database=ComputerShop;user=root;password=er266914");
           } 
           public DbSet<Computer> Computers {get;set;}
           public DbSet<Category> Categories {get;set;}
           public DbSet<Admin> Admins {get;set;}
    }
}
