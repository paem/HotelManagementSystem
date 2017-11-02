namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requireddataannotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CustomerFName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "CustomerLName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "CustomerAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "CustomerCity", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "CustomerCountry", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "CustomerPhoneNo", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "CustomerEmail", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Password", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Password", c => c.String(maxLength: 25));
            AlterColumn("dbo.Customers", "CustomerEmail", c => c.String());
            AlterColumn("dbo.Customers", "CustomerPhoneNo", c => c.String());
            AlterColumn("dbo.Customers", "CustomerCountry", c => c.String());
            AlterColumn("dbo.Customers", "CustomerCity", c => c.String());
            AlterColumn("dbo.Customers", "CustomerAddress", c => c.String());
            AlterColumn("dbo.Customers", "CustomerLName", c => c.String());
            AlterColumn("dbo.Customers", "CustomerFName", c => c.String());
        }
    }
}
