namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class navigationproperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "RoomCategory_RoomCategoryId", c => c.Int());
            AddColumn("dbo.RoomCategories", "Room_RoomId", c => c.Int());
            AddColumn("dbo.RoomCapacities", "Room_RoomId", c => c.Int());
            AddColumn("dbo.RoomCapacities", "RoomCategory_RoomCategoryId", c => c.Int());
            CreateIndex("dbo.Rooms", "RoomCategory_RoomCategoryId");
            CreateIndex("dbo.RoomCapacities", "Room_RoomId");
            CreateIndex("dbo.RoomCapacities", "RoomCategory_RoomCategoryId");
            CreateIndex("dbo.RoomCategories", "Room_RoomId");
            AddForeignKey("dbo.RoomCapacities", "Room_RoomId", "dbo.Rooms", "RoomId");
            AddForeignKey("dbo.RoomCapacities", "RoomCategory_RoomCategoryId", "dbo.RoomCategories", "RoomCategoryId");
            AddForeignKey("dbo.Rooms", "RoomCategory_RoomCategoryId", "dbo.RoomCategories", "RoomCategoryId");
            AddForeignKey("dbo.RoomCategories", "Room_RoomId", "dbo.Rooms", "RoomId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomCategories", "Room_RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "RoomCategory_RoomCategoryId", "dbo.RoomCategories");
            DropForeignKey("dbo.RoomCapacities", "RoomCategory_RoomCategoryId", "dbo.RoomCategories");
            DropForeignKey("dbo.RoomCapacities", "Room_RoomId", "dbo.Rooms");
            DropIndex("dbo.RoomCategories", new[] { "Room_RoomId" });
            DropIndex("dbo.RoomCapacities", new[] { "RoomCategory_RoomCategoryId" });
            DropIndex("dbo.RoomCapacities", new[] { "Room_RoomId" });
            DropIndex("dbo.Rooms", new[] { "RoomCategory_RoomCategoryId" });
            DropColumn("dbo.RoomCapacities", "RoomCategory_RoomCategoryId");
            DropColumn("dbo.RoomCapacities", "Room_RoomId");
            DropColumn("dbo.RoomCategories", "Room_RoomId");
            DropColumn("dbo.Rooms", "RoomCategory_RoomCategoryId");
        }
    }
}
