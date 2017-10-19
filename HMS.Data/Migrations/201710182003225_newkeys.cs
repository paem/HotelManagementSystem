namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newkeys : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "RoomCategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Rooms", "RoomCapacityId", c => c.Int(nullable: false));
            AddColumn("dbo.RoomCategories", "RoomCapacityId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RoomCategories", "RoomCapacityId");
            DropColumn("dbo.Rooms", "RoomCapacityId");
            DropColumn("dbo.Bookings", "RoomCategoryId");
        }
    }
}
