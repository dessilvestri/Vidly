namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newbegining5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Genre_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Genre_Id", c => c.Int(nullable: false));
        }
    }
}
