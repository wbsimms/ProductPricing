using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ProductPricing.Web.Models
{
    public class ProductPricingViewModel
    {
        public List<SelectListItem> Products { get; set; }
        public int SelectedProduct { get; set; }
        public List<ListItem> Size { get; set; }
        public int SelectedSize { get; set; }

    }
}