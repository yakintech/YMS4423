namespace BilgeAdam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductandCategoryCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Description = c.String(),
                        AddDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AddDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        Category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Category", t => t.Category_ID)
                .Index(t => t.Category_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Category_ID", "dbo.Category");
            DropIndex("dbo.Product", new[] { "Category_ID" });
            DropTable("dbo.Product");
            DropTable("dbo.Category");
        }
    }
}
