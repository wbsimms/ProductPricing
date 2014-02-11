using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using ProductPricing.DataAccess.Models;

namespace ProductPricing.DataAccess
{
    public class ProductPricingContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
