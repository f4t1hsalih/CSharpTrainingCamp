namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStatusToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Status");
        }
    }
}
