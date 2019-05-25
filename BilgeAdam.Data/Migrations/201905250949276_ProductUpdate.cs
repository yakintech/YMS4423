namespace BilgeAdam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "ImgPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "ImgPath");
        }
    }
}
