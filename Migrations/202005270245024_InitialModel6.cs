namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "typeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "typeId");
        }
    }
}
