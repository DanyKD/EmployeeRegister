namespace EmployeeRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeesFirstName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "FirstName", c => c.String(nullable: false));
            
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "LastName", c => c.String());
            
        }
    }
}
