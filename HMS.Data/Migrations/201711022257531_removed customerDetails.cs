namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedcustomerDetails : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CustomerDetails", "CustomerId", "dbo.Customers");
            DropIndex("dbo.CustomerDetails", new[] { "CustomerId" });
            AddColumn("dbo.Customers", "CheckedIn", c => c.Boolean(nullable: false));
            DropTable("dbo.CustomerDetails");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CustomerDetails",
                c => new
                    {
                        CustomerDetailsId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        CheckedIn = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerDetailsId);
            
            DropColumn("dbo.Customers", "CheckedIn");
            CreateIndex("dbo.CustomerDetails", "CustomerId");
            AddForeignKey("dbo.CustomerDetails", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
        }
    }
}
