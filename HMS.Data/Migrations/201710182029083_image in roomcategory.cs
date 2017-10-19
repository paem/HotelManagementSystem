namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imageinroomcategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RoomCategories", "RoomCategoryImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RoomCategories", "RoomCategoryImage");
        }
    }
}
