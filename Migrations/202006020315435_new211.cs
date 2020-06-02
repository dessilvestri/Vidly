namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new211 : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Movies", "FK__Movies__Genre_Id__09A971A2", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropColumn("dbo.Movies", "Genre_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Genre_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "Genre_Id");
            //AddForeignKey("dbo.Movies", "FK__Movies__Genre_Id__09A971A2", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
