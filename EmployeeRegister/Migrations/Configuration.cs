namespace EmployeeRegister.Migrations
{
    using EmployeeRegister.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeRegister.Models.EmployeeRegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            
        }

        protected override void Seed(EmployeeRegister.Models.EmployeeRegisterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Employees.AddOrUpdate(               
                new Employee { FirstName = "Dany", LastName = "KassDaoud", Salary = 35000, Position = "FSS", Department = "Sales", BirthDate=DateTime.Now},
                new Employee { FirstName = "Tony", LastName = "Abdo", Salary = 30000, Position = "Treasury", Department = "Finance", BirthDate = DateTime.Now },
                new Employee { FirstName = "Nada", LastName = "Maatouk", Salary = 40000, Position = "DP", Department = "SupplyChain", BirthDate = DateTime.Now },
                new Employee { FirstName = "Maher", LastName = "AboHelaneh", Salary = 55000, Position = "MDS", Department = "Sport", BirthDate = DateTime.Now },
                new Employee { FirstName = "Jean", LastName = "Sano", Salary = 75000, Position = "Manager", Department = "Sales", BirthDate = DateTime.Now }
                );
        }
    }
}
