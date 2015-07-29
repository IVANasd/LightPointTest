using LightPointTest.Models;
using LightPointTest.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LightPointTest.Controllers
{
    public class ShopController : Controller
    {
        private LptDbContext db = new LptDbContext();
        //
        // GET: /Shop/
        public ActionResult Index()
        {
            var shops = db.Shops.Select(s => new ShopViewModel()
            {
                Id = s.Id,
                Name = s.Name,
                Address = s.Address
            });
            return View(shops);
        }
	}
}