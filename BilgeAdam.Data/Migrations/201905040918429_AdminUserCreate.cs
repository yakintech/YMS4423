namespace BilgeAdam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminUserCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminUser",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EMail = c.String(nullable: false, maxLength: 100),
                        Password = c.String(),
                        InsertedUserID = c.Int(nullable: false),
                        UpdatedUserID = c.Int(nullable: false),
                        DeletedUserID = c.Int(),
                        AddDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AdminUser");
        }
    }
}
