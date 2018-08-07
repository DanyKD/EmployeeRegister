namespace EmployeeRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "PersonalNumber", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "PersonalNumber");
        }
    }
}
