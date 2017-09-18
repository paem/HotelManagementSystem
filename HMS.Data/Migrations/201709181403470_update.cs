namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Rooms", "RoomCapacityId");
            DropColumn("dbo.Rooms", "RoomCategoryId");
            DropColumn("dbo.Rooms", "RoomPriceId");
            DropColumn("dbo.Rooms", "RoomPrices");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "RoomPrices", c => c.Single(nullable: false));
            AddColumn("dbo.Rooms", "RoomPriceId", c => c.Int(nullable: false));
            AddColumn("dbo.Rooms", "RoomCategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Rooms", "RoomCapacityId", c => c.Int(nullable: false));
        }
    }
}
