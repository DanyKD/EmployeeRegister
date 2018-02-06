namespace EmployeeRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Employees1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "FirstName", c => c.String(nullable: false, maxLength: 30));            
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "LastName", c => c.String());            
        }
    }
}
