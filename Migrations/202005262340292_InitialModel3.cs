namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "TypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "TypeId", c => c.Int(nullable: false));
        }
    }
}
