namespace Paperoni.Data.Access.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Paperoni.Data.Access.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LibraryContext context)
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

            
            // Testing
            //var bookRepo = new BookRepository(context);
            //bookRepo.Add(new Entities.Book {
            //    ID = new Guid("BC063228-22E9-4D60-8BB9-2C660D1E4139"),
            //    Title = "The humbper",
            //    Description = "None",
            //    ISBN = "Test"
            //});
        }
    }
}
