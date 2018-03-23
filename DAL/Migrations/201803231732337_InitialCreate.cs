namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guest",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Birthdate = c.DateTime(nullable: false),
                        PostCode = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reservation",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 10),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreationDate = c.DateTime(nullable: false),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        Currency = c.String(nullable: false),
                        Commission = c.Int(nullable: false),
                        Source = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ReservationGuest",
                c => new
                    {
                        Reservation_ID = c.Int(nullable: false),
                        Guest_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reservation_ID, t.Guest_ID })
                .ForeignKey("dbo.Reservation", t => t.Reservation_ID, cascadeDelete: true)
                .ForeignKey("dbo.Guest", t => t.Guest_ID, cascadeDelete: true)
                .Index(t => t.Reservation_ID)
                .Index(t => t.Guest_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReservationGuest", "Guest_ID", "dbo.Guest");
            DropForeignKey("dbo.ReservationGuest", "Reservation_ID", "dbo.Reservation");
            DropIndex("dbo.ReservationGuest", new[] { "Guest_ID" });
            DropIndex("dbo.ReservationGuest", new[] { "Reservation_ID" });
            DropTable("dbo.ReservationGuest");
            DropTable("dbo.Reservation");
            DropTable("dbo.Guest");
        }
    }
}
