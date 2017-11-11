namespace WebShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(nullable: false, maxLength: 500),
                        StackTrace = c.String(maxLength: 500),
                        CreatedDate = c.DateTime(storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MenuGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        URL = c.String(nullable: false, maxLength: 256),
                        DisplayOrder = c.Int(nullable: false),
                        GroupID = c.Int(nullable: false),
                        Target = c.String(maxLength: 10),
                        Status = c.Boolean(nullable: false),
                        MenuGroup_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MenuGroups", t => t.MenuGroup_ID)
                .Index(t => t.MenuGroup_ID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID })
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 256),
                        CustomerAddress = c.String(nullable: false, maxLength: 356),
                        CustomerEmail = c.String(maxLength: 256),
                        CustomerMobile = c.String(maxLength: 256),
                        CustomerMessage = c.String(maxLength: 500),
                        CreatedDate = c.DateTime(storeType: "smalldatetime"),
                        CreatedBy = c.String(maxLength: 256),
                        PaymentMethod = c.String(maxLength: 256),
                        PaymentStatus = c.String(maxLength: 100),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        CategoryID = c.Int(nullable: false),
                        Image = c.String(maxLength: 256),
                        MoreImages = c.String(storeType: "xml"),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PromotionPrice = c.Decimal(precision: 18, scale: 2),
                        Warranty = c.Int(),
                        Description = c.String(maxLength: 500),
                        Content = c.String(maxLength: 500),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(),
                        CreatedDate = c.DateTime(storeType: "smalldatetime"),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(storeType: "smalldatetime"),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 500),
                        Status = c.Boolean(nullable: false),
                        ProductCategory_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategory_ID)
                .Index(t => t.ProductCategory_ID);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false),
                        Description = c.String(maxLength: 500),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(),
                        Image = c.String(maxLength: 256),
                        HomeFlag = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(storeType: "smalldatetime"),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(storeType: "smalldatetime"),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 456),
                        MetaDescription = c.String(maxLength: 456),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductTags",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ProductID, t.TagID })
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Type = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        PostID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.PostID, t.TagID })
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.PostID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        CategoryID = c.Int(nullable: false),
                        Image = c.String(maxLength: 500),
                        Content = c.String(maxLength: 256),
                        Description = c.String(maxLength: 500),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(nullable: false),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(),
                        CreatedDate = c.DateTime(storeType: "smalldatetime"),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(storeType: "smalldatetime"),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 500),
                        MetaDescription = c.String(maxLength: 500),
                        Status = c.Boolean(nullable: false),
                        PostCategory_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PostCategories", t => t.PostCategory_ID)
                .Index(t => t.PostCategory_ID);
            
            CreateTable(
                "dbo.PostCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        Description = c.String(maxLength: 500),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(),
                        Image = c.String(maxLength: 500),
                        HomeFlag = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(storeType: "smalldatetime"),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 500),
                        MetaDescription = c.String(maxLength: 500),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Content = c.String(maxLength: 500),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        CreatedDate = c.DateTime(storeType: "smalldatetime"),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(storeType: "smalldatetime"),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 500),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 500),
                        Image = c.String(maxLength: 256),
                        URL = c.String(maxLength: 256),
                        DisplayOrder = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SupportOnlines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Department = c.String(maxLength: 256),
                        Skype = c.String(maxLength: 256),
                        Mobile = c.String(maxLength: 20),
                        Email = c.String(maxLength: 256),
                        Facebook = c.String(maxLength: 256),
                        Yahoo = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SystemConfigs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 256, unicode: false),
                        ValueString = c.String(maxLength: 256),
                        ValueInt = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        VisitedDate = c.DateTime(storeType: "smalldatetime"),
                        IPAddress = c.String(maxLength: 456),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.PostTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.PostTags", "PostID", "dbo.Posts");
            DropForeignKey("dbo.Posts", "PostCategory_ID", "dbo.PostCategories");
            DropForeignKey("dbo.ProductTags", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductCategory_ID", "dbo.ProductCategories");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Menus", "MenuGroup_ID", "dbo.MenuGroups");
            DropIndex("dbo.Posts", new[] { "PostCategory_ID" });
            DropIndex("dbo.PostTags", new[] { "TagID" });
            DropIndex("dbo.PostTags", new[] { "PostID" });
            DropIndex("dbo.ProductTags", new[] { "TagID" });
            DropIndex("dbo.ProductTags", new[] { "ProductID" });
            DropIndex("dbo.Products", new[] { "ProductCategory_ID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Menus", new[] { "MenuGroup_ID" });
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.SystemConfigs");
            DropTable("dbo.SupportOnlines");
            DropTable("dbo.Slides");
            DropTable("dbo.Pages");
            DropTable("dbo.PostCategories");
            DropTable("dbo.Posts");
            DropTable("dbo.PostTags");
            DropTable("dbo.Tags");
            DropTable("dbo.ProductTags");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Menus");
            DropTable("dbo.MenuGroups");
            DropTable("dbo.Footers");
            DropTable("dbo.Errors");
        }
    }
}
