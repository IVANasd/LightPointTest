using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LightPointTest.Models.DbModels;

namespace LightPointTest.Models
{
    public class LptDbContext:DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        public LptDbContext()
            : base("LptDB")
        {

        }
    }
}