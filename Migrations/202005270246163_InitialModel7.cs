namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel7 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "typeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "typeId", c => c.Int(nullable: false));
        }
    }
}
