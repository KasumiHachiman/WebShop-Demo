namespace WebShop.Data.Migrations
{
    using Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebShop.Data.WebShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebShop.Data.WebShopDbContext context)
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
            ConfigValue(context);
        }

        private void ConfigValue(WebShopDbContext context)
        {
            List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory() { Name="Dien lanh",Alias= "dien-lanh",Status = false },
                new ProductCategory() { Name="Dien dan dung",Alias= "dien-dan-dung",Status = false },
                new ProductCategory() { Name="Do gia dung",Alias= "do-gia-dung",Status = true },
                new ProductCategory() { Name="Vien thong",Alias= "vien-thong",Status = true },
                new ProductCategory() { Name="My pham",Alias= "vien-thong",Status = false }
                
            };
            context.ProductCategories.AddRange(listProductCategory);
            context.SaveChanges();

        }
    }
}
