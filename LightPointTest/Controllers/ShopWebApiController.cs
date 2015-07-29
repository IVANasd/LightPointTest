using LightPointTest.Models;
using LightPointTest.Models.DbModels;
using LightPointTest.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LightPointTest.Controllers
{
    [RoutePrefix("Shop")]
    public class ShopWebApiController : ApiController
    {
        private LptDbContext db = new LptDbContext();
        
        
        [Route("")]
        public IEnumerable<ShopViewModel> GetAll()
        {
            var shops = db.Shops.Select(s => new ShopViewModel()
            {
                Id = s.Id,
                Name = s.Name,
                Address = s.Address
            });
            return shops;
        }

        [Route("{shopId}/Products")]
        public IHttpActionResult GetProducts(int shopId)
        {
            var shop = db.Shops.Find(shopId);
            if (shop == null)
            {
                return BadRequest();
            }

            var products = db.Shops.Find(shopId).Products.Select(
                p=>new ProductViewModel(){
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description
            });
            return Ok(products);
        }
    }
}
