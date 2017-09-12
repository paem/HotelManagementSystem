namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingId = c.Int(nullable: false, identity: true),
                        BookingDate = c.DateTime(nullable: false),
                        BookingArrivalDate = c.DateTime(nullable: false),
                        BookingDepartureDate = c.DateTime(nullable: false),
                        BookingRoomCategoryId = c.Int(nullable: false),
                        BookingRoomId = c.Int(nullable: false),
                        BookingCustomerId = c.Int(nullable: false),
                        BookingStatus = c.Boolean(nullable: false),
                        BookingTotalNights = c.Int(nullable: false),
                        BookingTotalRooms = c.Int(nullable: false),
                        BookingTotalAdults = c.Int(nullable: false),
                        BookingTotalChilds = c.Int(nullable: false),
                        BookingTotalCost = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.BookingId);
            
            CreateTable(
                "dbo.CustomerDetails",
                c => new
                    {
                        CustomerDetailsId = c.Int(nullable: false, identity: true),
                        CheckedIn = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerDetailsId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerFName = c.String(),
                        CustomerLName = c.String(),
                        CustomerGender = c.String(),
                        CustomerAddress = c.String(),
                        CustomerCity = c.String(),
                        CustomerPhoneNo = c.String(),
                        CustomerEmail = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        HotelId = c.Int(nullable: false, identity: true),
                        HotelName = c.String(),
                        HotelDescription = c.String(),
                        HotelTotalRooms = c.Int(nullable: false),
                        HotelTotalFloors = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HotelId);
            
            CreateTable(
                "dbo.RoomCapacities",
                c => new
                    {
                        RoomCapacityId = c.Int(nullable: false, identity: true),
                        RoomCapacityName = c.String(),
                        RoomCapacityAdults = c.Int(nullable: false),
                        RoomCapacityChilds = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomCapacityId);
            
            CreateTable(
                "dbo.RoomCategories",
                c => new
                    {
                        RoomCategoryId = c.Int(nullable: false, identity: true),
                        RoomCategoryName = c.String(),
                        RoomCategoryDescription = c.String(),
                        RoomCategoryBeds = c.String(),
                        RoomCapacityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomCategoryId);
            
            CreateTable(
                "dbo.RoomPrices",
                c => new
                    {
                        RoomPriceId = c.Int(nullable: false, identity: true),
                        RoomPriceName = c.String(),
                        RoomPrices = c.Single(nullable: false),
                        RoomCategoryId = c.Int(nullable: false),
                        RoomCapacityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomPriceId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        RoomDoorNumber = c.Int(nullable: false),
                        RoomCategoryId = c.Int(nullable: false),
                        RoomCount = c.Int(nullable: false),
                        RoomStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RoomId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rooms");
            DropTable("dbo.RoomPrices");
            DropTable("dbo.RoomCategories");
            DropTable("dbo.RoomCapacities");
            DropTable("dbo.Hotels");
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerDetails");
            DropTable("dbo.Bookings");
        }
    }
}
