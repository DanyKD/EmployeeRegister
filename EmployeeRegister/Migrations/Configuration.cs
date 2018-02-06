namespace EmployeeRegister.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeRegister.Models.EmployeeRegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EmployeeRegister.Models.EmployeeRegisterContext";
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
                p => p.FirstName,
                new Models.Employee { FirstName = "Dany", LastName = "KassDaoud", Salary = 35000, Position = "FSS", Department = "Sales" },
                new Models.Employee { FirstName = "Tony", LastName = "Abdo", Salary = 30000, Position = "Treasury", Department = "Finance" },
                new Models.Employee { FirstName = "Nada", LastName = "Maatouk", Salary = 40000, Position = "DP", Department = "SupplyChain" },
                new Models.Employee { FirstName = "Maher", LastName = "AboHelaneh", Salary = 55000, Position = "MDS", Department = "Sport" },
                new Models.Employee { FirstName = "Jean", LastName = "Sano", Salary = 75000, Position = "Manager", Department = "Sales" }
                );
        }
    }
}
