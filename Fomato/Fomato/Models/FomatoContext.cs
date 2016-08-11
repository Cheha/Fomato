using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fomato.Models
{
    public class FomatoContext : DbContext
    {
        public FomatoContext() : base("Fomato") { 
        
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}