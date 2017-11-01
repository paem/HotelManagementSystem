namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rooms", "RoomCapacityId", "dbo.RoomCapacities");
            DropIndex("dbo.Rooms", new[] { "RoomCapacityId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Rooms", "RoomCapacityId");
            AddForeignKey("dbo.Rooms", "RoomCapacityId", "dbo.RoomCapacities", "RoomCapacityId", cascadeDelete: true);
        }
    }
}
