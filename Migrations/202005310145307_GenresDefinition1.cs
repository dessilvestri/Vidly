namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenresDefinition1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES(Name) Values('Comedy')");
            Sql("INSERT INTO GENRES(Name) Values('Family')");
            Sql("INSERT INTO GENRES(Name) Values('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
