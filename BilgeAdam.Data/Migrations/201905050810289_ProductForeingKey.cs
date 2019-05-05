namespace BilgeAdam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductForeingKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Product", "Category_ID", "dbo.Category");
            DropIndex("dbo.Product", new[] { "Category_ID" });
            RenameColumn(table: "dbo.Product", name: "Category_ID", newName: "CategoryID");
            AlterColumn("dbo.Product", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Product", "CategoryID");
            AddForeignKey("dbo.Product", "CategoryID", "dbo.Category", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "CategoryID", "dbo.Category");
            DropIndex("dbo.Product", new[] { "CategoryID" });
            AlterColumn("dbo.Product", "CategoryID", c => c.Int());
            RenameColumn(table: "dbo.Product", name: "CategoryID", newName: "Category_ID");
            CreateIndex("dbo.Product", "Category_ID");
            AddForeignKey("dbo.Product", "Category_ID", "dbo.Category", "ID");
        }
    }
}
