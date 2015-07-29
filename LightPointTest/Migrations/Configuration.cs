namespace LightPointTest.Migrations
{
    using LightPointTest.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LightPointTest.Models.LptDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LightPointTest.Models.LptDbContext";
        }

        private List<Product> GetProducts(int count, string namePrefix)
        {
            List<Product> products = new List<Product>();

            for (int i = 0; i < count; i++)
            {
                products.Add(new Product()
                {
                    Name = namePrefix + count,
                    Description = "description for " + namePrefix + count
                });
            }

            return products;
        }

        private List<Shop> GetShops()
        {
            List<Shop> shops = new List<Shop>();
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                shops.Add(new Shop()
                {
                    Name = "shop ¹"+i,
                    Address = "Address for "+i,
                    Products = GetProducts(rnd.Next(100), i+"shopProduct")
                });
            }

            return shops;
        }

        protected override void Seed(LightPointTest.Models.LptDbContext context)
        {
            context.Shops.AddRange(GetShops());
            context.SaveChanges();
        }
    }
}
