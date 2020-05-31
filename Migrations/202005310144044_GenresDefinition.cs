namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenresDefinition : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES(Name) Values('Action')");
        }
        
        public override void Down()
        {
        }
    }
}
