namespace BilgeAdam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WebUserCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WebUser",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EMail = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        SurName = c.String(),
                        LastLoginDate = c.DateTime(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WebUser");
        }
    }
}
