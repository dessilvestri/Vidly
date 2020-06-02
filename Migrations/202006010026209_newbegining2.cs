namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newbegining2 : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Movies ADD FOREIGN KEY (GenreId) REFERENCES Genre(Id)");
        }
        
        public override void Down()
        {
        }
    }
}
