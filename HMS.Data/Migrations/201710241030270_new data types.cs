namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdatatypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bookings", "BookingTotalCost", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bookings", "BookingTotalCost", c => c.Single(nullable: false));
        }
    }
}
