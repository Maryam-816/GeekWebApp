namespace GeekWebAppProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactsModelsRenamedToContactMessages : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ContactsModels", newName: "ContactMessages");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ContactMessages", newName: "ContactsModels");
        }
    }
}
