namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newClassGenre1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "GenreName_Id", c => c.Int());
            CreateIndex("dbo.Movies", "GenreName_Id");
            AddForeignKey("dbo.Movies", "GenreName_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreName_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreName_Id" });
            DropColumn("dbo.Movies", "GenreName_Id");
            DropTable("dbo.Genres");
        }
    }
}
