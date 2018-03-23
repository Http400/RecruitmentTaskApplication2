namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewPropertiesToGuestEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guest", "PhoneNumber", c => c.String());
            AddColumn("dbo.Guest", "Address", c => c.String());
            AddColumn("dbo.Guest", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Guest", "City");
            DropColumn("dbo.Guest", "Address");
            DropColumn("dbo.Guest", "PhoneNumber");
        }
    }
}
