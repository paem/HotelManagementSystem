namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "RoomCapacity_RoomCapacityId", c => c.Int());
            CreateIndex("dbo.Rooms", "RoomCapacity_RoomCapacityId");
            AddForeignKey("dbo.Rooms", "RoomCapacity_RoomCapacityId", "dbo.RoomCapacities", "RoomCapacityId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "RoomCapacity_RoomCapacityId", "dbo.RoomCapacities");
            DropIndex("dbo.Rooms", new[] { "RoomCapacity_RoomCapacityId" });
            DropColumn("dbo.Rooms", "RoomCapacity_RoomCapacityId");
        }
    }
}
