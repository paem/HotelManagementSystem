namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "RoomPrice", c => c.Double(nullable: false));
            DropColumn("dbo.Rooms", "RoomPriceName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "RoomPriceName", c => c.String());
            DropColumn("dbo.Rooms", "RoomPrice");
        }
    }
}
