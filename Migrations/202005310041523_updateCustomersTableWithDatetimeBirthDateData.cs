namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCustomersTableWithDatetimeBirthDateData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '2010/01/1' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
