using System.Data.Entity;
using WebShop.Model.Mappers;
using WebShop.Model.Models;

namespace WebShop.Data
{
    public class WebShopDbContext : DbContext
    {
        public WebShopDbContext()
            :base("webshop")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

            //sDatabase.SetInitializer(new MigrateDatabaseToLatestVersion<WebShopDbContext, LearningContextMigrationConfiguration>());
        }
        public DbSet<Error> Errors { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ErrorMapper());
            modelBuilder.Configurations.Add(new FooterMapper());
            modelBuilder.Configurations.Add(new MenuMapper());
            modelBuilder.Configurations.Add(new MenuGroupMapper());
            modelBuilder.Configurations.Add(new OrderMapper());
            modelBuilder.Configurations.Add(new OrderDetailMapper());
            modelBuilder.Configurations.Add(new PageMapper());
            modelBuilder.Configurations.Add(new PostCategoryMapper());
            modelBuilder.Configurations.Add(new PostMapper());
            modelBuilder.Configurations.Add(new PostTagMapper());
            modelBuilder.Configurations.Add(new ProductCategoryMapper());
            modelBuilder.Configurations.Add(new ProductMapper());
            modelBuilder.Configurations.Add(new ProductTagMapper());
            modelBuilder.Configurations.Add(new SlideMapper());
            modelBuilder.Configurations.Add(new SupportOnlineMapper());
            modelBuilder.Configurations.Add(new SystemConfigMapper());
            modelBuilder.Configurations.Add(new TagMapper());
            modelBuilder.Configurations.Add(new VisitorStatisticMapper());
            base.OnModelCreating(modelBuilder);
        }
    }
}