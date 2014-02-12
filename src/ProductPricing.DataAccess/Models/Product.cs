using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPricing.DataAccess.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public string Size { get; set; }
        public int Runsize { get; set; }
        public string TurnAroundTime { get; set; }
        public string Stock { get; set; }
        public string Description { get; set; }
        public string ShippingOptions { get; set; }
        public string Price { get; set; }



    }
}
