using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LightPointTest.Models.DbModels
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //TODO WorkTime
        public virtual ICollection<Product> Products { get; set; }
    }
}