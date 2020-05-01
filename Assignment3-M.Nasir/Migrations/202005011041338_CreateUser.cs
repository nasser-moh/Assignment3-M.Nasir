namespace Assignment3_M.Nasir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUser : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CheckingAccounts(AccountNumber,FirstName,LastName,Balance) VALUES('7101650000','Mohamad','Nasser',23657)");
        }
        
        public override void Down()
        {
        }
    }
}
