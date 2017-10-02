namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmig : DbMigration
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
                        RoomCategoryId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        BookingStatus = c.Boolean(nullable: false),
                        BookingTotalNights = c.Int(nullable: false),
                        BookingTotalRooms = c.Int(nullable: false),
                        BookingTotalAdults = c.Int(nullable: false),
                        BookingTotalChilds = c.Int(nullable: false),
                        BookingTotalCost = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.BookingId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.RoomCategories", t => t.RoomCategoryId, cascadeDelete: true)
                .Index(t => t.RoomCategoryId)
                .Index(t => t.RoomId)
                .Index(t => t.CustomerId);
            
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
                        CustomerCountry = c.String(),
                        CustomerPhoneNo = c.String(),
                        CustomerEmail = c.String(),
                        Password = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        RoomDoorNumber = c.Int(nullable: false),
                        RoomCount = c.Int(nullable: false),
                        RoomStatus = c.Boolean(nullable: false),
                        RoomCategoryId = c.Int(),
                        RoomPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.RoomId)
                .ForeignKey("dbo.RoomCategories", t => t.RoomCategoryId)
                .Index(t => t.RoomCategoryId);
            
            CreateTable(
                "dbo.RoomCategories",
                c => new
                    {
                        RoomCategoryId = c.Int(nullable: false, identity: true),
                        RoomCategoryName = c.String(),
                        RoomCategoryDesc = c.String(),
                        RoomCategoryBeds = c.String(),
                        RoomCapacityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomCategoryId)
                .ForeignKey("dbo.RoomCapacities", t => t.RoomCapacityId, cascadeDelete: true)
                .Index(t => t.RoomCapacityId);
            
            CreateTable(
                "dbo.RoomCapacities",
                c => new
                    {
                        RoomCapacityId = c.Int(nullable: false, identity: true),
                        RoomCapacityName = c.String(),
                        RoomCapacityAdults = c.Int(nullable: false),
                        RoomCapacityChildren = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomCapacityId);
            
            CreateTable(
                "dbo.CustomerDetails",
                c => new
                    {
                        CustomerDetailsId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        CheckedIn = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerDetailsId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerDetails", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Bookings", "RoomCategoryId", "dbo.RoomCategories");
            DropForeignKey("dbo.Bookings", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "RoomCategoryId", "dbo.RoomCategories");
            DropForeignKey("dbo.RoomCategories", "RoomCapacityId", "dbo.RoomCapacities");
            DropForeignKey("dbo.Bookings", "CustomerId", "dbo.Customers");
            DropIndex("dbo.CustomerDetails", new[] { "CustomerId" });
            DropIndex("dbo.RoomCategories", new[] { "RoomCapacityId" });
            DropIndex("dbo.Rooms", new[] { "RoomCategoryId" });
            DropIndex("dbo.Bookings", new[] { "CustomerId" });
            DropIndex("dbo.Bookings", new[] { "RoomId" });
            DropIndex("dbo.Bookings", new[] { "RoomCategoryId" });
            DropTable("dbo.Hotels");
            DropTable("dbo.CustomerDetails");
            DropTable("dbo.RoomCapacities");
            DropTable("dbo.RoomCategories");
            DropTable("dbo.Rooms");
            DropTable("dbo.Customers");
            DropTable("dbo.Bookings");
        }
    }
}
