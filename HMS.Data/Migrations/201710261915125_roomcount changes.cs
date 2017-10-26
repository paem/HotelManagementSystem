namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class roomcountchanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RoomCategories", "RoomCount", c => c.Double(nullable: false));
            DropColumn("dbo.Rooms", "RoomCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "RoomCount", c => c.Int(nullable: false));
            DropColumn("dbo.RoomCategories", "RoomCount");
        }
    }
}
