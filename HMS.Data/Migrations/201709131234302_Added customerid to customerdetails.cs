namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedcustomeridtocustomerdetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerDetails", "CustomerId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerDetails", "CustomerId");
        }
    }
}
