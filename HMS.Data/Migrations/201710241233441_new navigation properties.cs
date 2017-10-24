namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newnavigationproperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "Booking_BookingId", c => c.Int());
            AddColumn("dbo.RoomCapacities", "Booking_BookingId", c => c.Int());
            AddColumn("dbo.RoomCategories", "Booking_BookingId", c => c.Int());
            CreateIndex("dbo.Rooms", "Booking_BookingId");
            CreateIndex("dbo.RoomCapacities", "Booking_BookingId");
            CreateIndex("dbo.RoomCategories", "Booking_BookingId");
            AddForeignKey("dbo.RoomCapacities", "Booking_BookingId", "dbo.Bookings", "BookingId");
            AddForeignKey("dbo.RoomCategories", "Booking_BookingId", "dbo.Bookings", "BookingId");
            AddForeignKey("dbo.Rooms", "Booking_BookingId", "dbo.Bookings", "BookingId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "Booking_BookingId", "dbo.Bookings");
            DropForeignKey("dbo.RoomCategories", "Booking_BookingId", "dbo.Bookings");
            DropForeignKey("dbo.RoomCapacities", "Booking_BookingId", "dbo.Bookings");
            DropIndex("dbo.RoomCategories", new[] { "Booking_BookingId" });
            DropIndex("dbo.RoomCapacities", new[] { "Booking_BookingId" });
            DropIndex("dbo.Rooms", new[] { "Booking_BookingId" });
            DropColumn("dbo.RoomCategories", "Booking_BookingId");
            DropColumn("dbo.RoomCapacities", "Booking_BookingId");
            DropColumn("dbo.Rooms", "Booking_BookingId");
        }
    }
}
