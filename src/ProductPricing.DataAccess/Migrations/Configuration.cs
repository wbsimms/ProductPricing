using ProductPricing.DataAccess.Models;

namespace ProductPricing.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductPricing.DataAccess.ProductPricingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProductPricing.DataAccess.ProductPricingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.ProductTypes.AddOrUpdate(x => x.Name,
                new ProductType {Name = "Postcards",Description = ""},
                new ProductType() {Name ="Business Cards",Description = ""},
                new ProductType() {Name = "Notepads", Description = ""},
                new ProductType() {Name ="Flyers and Brochures",Description = ""});

            context.SaveChanges();
        }
    }
}
