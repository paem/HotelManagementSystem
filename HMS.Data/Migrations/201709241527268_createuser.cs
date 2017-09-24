namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createuser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerCountry", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerCountry");
        }
    }
}
