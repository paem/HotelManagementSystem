namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRoomtoone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "RoomCapacityId", c => c.Int(nullable: false));
            AddColumn("dbo.Rooms", "RoomCapacityName", c => c.String());
            AddColumn("dbo.Rooms", "RoomCapacityAdults", c => c.Int(nullable: false));
            AddColumn("dbo.Rooms", "RoomCapacityChilds", c => c.Int(nullable: false));
            AddColumn("dbo.Rooms", "RoomCategoryName", c => c.String());
            AddColumn("dbo.Rooms", "RoomCategoryDescription", c => c.String());
            AddColumn("dbo.Rooms", "RoomCategoryBeds", c => c.String());
            AddColumn("dbo.Rooms", "RoomPriceId", c => c.Int(nullable: false));
            AddColumn("dbo.Rooms", "RoomPriceName", c => c.String());
            AddColumn("dbo.Rooms", "RoomPrices", c => c.Single(nullable: false));
            DropTable("dbo.RoomCapacities");
            DropTable("dbo.RoomCategories");
            DropTable("dbo.RoomPrices");
        }
        
        public override void Down()
        {
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
                "dbo.RoomCapacities",
                c => new
                    {
                        RoomCapacityId = c.Int(nullable: false, identity: true),
                        RoomCapacityName = c.String(),
                        RoomCapacityAdults = c.Int(nullable: false),
                        RoomCapacityChilds = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomCapacityId);
            
            DropColumn("dbo.Rooms", "RoomPrices");
            DropColumn("dbo.Rooms", "RoomPriceName");
            DropColumn("dbo.Rooms", "RoomPriceId");
            DropColumn("dbo.Rooms", "RoomCategoryBeds");
            DropColumn("dbo.Rooms", "RoomCategoryDescription");
            DropColumn("dbo.Rooms", "RoomCategoryName");
            DropColumn("dbo.Rooms", "RoomCapacityChilds");
            DropColumn("dbo.Rooms", "RoomCapacityAdults");
            DropColumn("dbo.Rooms", "RoomCapacityName");
            DropColumn("dbo.Rooms", "RoomCapacityId");
        }
    }
}
