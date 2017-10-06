namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LATESTMIG : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RoomCategories", "RoomCapacityId", "dbo.RoomCapacities");
            DropIndex("dbo.RoomCategories", new[] { "RoomCapacityId" });
            DropColumn("dbo.RoomCategories", "RoomCapacityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RoomCategories", "RoomCapacityId", c => c.Int(nullable: false));
            CreateIndex("dbo.RoomCategories", "RoomCapacityId");
            AddForeignKey("dbo.RoomCategories", "RoomCapacityId", "dbo.RoomCapacities", "RoomCapacityId", cascadeDelete: true);
        }
    }
}
