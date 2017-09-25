namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabasetables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "RoomId", c => c.Int(nullable: false));
            AddColumn("dbo.Bookings", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Bookings", "RoomId");
            CreateIndex("dbo.Bookings", "CustomerId");
            CreateIndex("dbo.CustomerDetails", "CustomerId");
            AddForeignKey("dbo.Bookings", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.Bookings", "RoomId", "dbo.Rooms", "RoomId", cascadeDelete: true);
            AddForeignKey("dbo.CustomerDetails", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            DropColumn("dbo.Bookings", "BookingRoomCategoryId");
            DropColumn("dbo.Bookings", "BookingRoomId");
            DropColumn("dbo.Bookings", "BookingCustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bookings", "BookingCustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Bookings", "BookingRoomId", c => c.Int(nullable: false));
            AddColumn("dbo.Bookings", "BookingRoomCategoryId", c => c.Int(nullable: false));
            DropForeignKey("dbo.CustomerDetails", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Bookings", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Bookings", "CustomerId", "dbo.Customers");
            DropIndex("dbo.CustomerDetails", new[] { "CustomerId" });
            DropIndex("dbo.Bookings", new[] { "CustomerId" });
            DropIndex("dbo.Bookings", new[] { "RoomId" });
            DropColumn("dbo.Bookings", "CustomerId");
            DropColumn("dbo.Bookings", "RoomId");
        }
    }
}
