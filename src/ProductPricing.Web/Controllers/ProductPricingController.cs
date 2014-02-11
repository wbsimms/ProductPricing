using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductPricing.Web.Models;

namespace ProductPricing.Web.Controllers
{
    public class ProductPricingController : Controller
    {
        //
        // GET: /ProductPricing/
        public ActionResult Index()
        {
            ProductPricingViewModel model = new ProductPricingViewModel();
            model.Products = new List<SelectListItem>()
            {
                new SelectListItem(){Selected = false,Text = "Notepads", Value = "1"},
                new SelectListItem(){Selected = false,Text = "Business Cards", Value = "1"},
                new SelectListItem(){Selected = false,Text = "Notecards", Value = "1"}
            };
            return View(model);
        }
	}
}