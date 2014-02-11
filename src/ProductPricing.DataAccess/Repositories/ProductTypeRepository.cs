using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductPricing.DataAccess.Models;

namespace ProductPricing.DataAccess.Repositories
{
    public interface IProductTypeRepository
    {
        List<ProductType> GetAll();
    }

    public class ProductTypeRepository : IProductTypeRepository
    {
        public List<ProductType> GetAll()
        {
            using (ProductPricingContext context = new ProductPricingContext())
            {
                context.Configuration.AutoDetectChangesEnabled = false;
                context.Configuration.LazyLoadingEnabled = false;
                context.Configuration.ProxyCreationEnabled = false;
                return context.ProductTypes.AsNoTracking().ToList();
            }
        }
    }
}
