namespace EmployeeRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "BirthDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "BirthDate");
        }
    }
}
