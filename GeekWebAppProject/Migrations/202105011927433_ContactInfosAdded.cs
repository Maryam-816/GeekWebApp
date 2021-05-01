namespace GeekWebAppProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactInfosAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Info = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactInfoes");
        }
    }
}
