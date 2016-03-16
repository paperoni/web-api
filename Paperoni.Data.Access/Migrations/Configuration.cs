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
            SeedBooks(context);
            SeedUsers(context);
        }

        /// <summary>
        /// Seeding all info related to books (book, author, publisher)
        /// </summary>
        private void SeedBooks(LibraryContext context)
        {
            var books = new[]
            {
                new Entities.Book
                {
                    ID = new Guid("BC063228-22E9-4D60-8BB9-2C660D1E4139"),
                    Title = "The slumber",
                    Description = "Some description",
                    ISBN = "SOME ISBN 0",
                    PublishedDate = new DateTime(2000, 10, 15)
                },
                new Entities.Book
                {
                    ID = new Guid("3529293E-4143-4C13-8F51-78E8896437C4"),
                    Title = "The number",
                    Description = "One two three....",
                    ISBN = "SOME ISBN 1",
                    PublishedDate = new DateTime(2000, 10, 15)
                },
                new Entities.Book
                {
                    ID = new Guid("4299460F-5416-4BBD-9DE8-9A0CEFDF72BD"),
                    Title = "The alphabet",
                    Description = "A b c d e",
                    ISBN = "SOME ISBN 2",
                    PublishedDate = new DateTime(2000, 10, 15)
                }
            };

            var authors = new[]
            {
                new Entities.Author
                {
                    ID = new Guid("FC991EBE-BBAA-441C-8661-914A522DD80C"),
                    FirstName = "Author 1",
                    LastName = "Dummy"

                },
                new Entities.Author
                {
                    ID = new Guid("91BFCDA3-75E6-4B08-8243-D019805F18AE"),
                    FirstName = "Author 2",
                    LastName = "Dummy 2"

                }
            };

            var publishers = new[]
            {
                new Entities.Publisher
                {
                    ID = new Guid("D3F0EA06-12A6-48EE-8DAF-09CAED027A8D"),
                    Name = "Simple publisher"
                },
                new Entities.Publisher
                {
                    ID = new Guid("5DA446AD-A22A-47A4-864D-F67E65BBCBBF"),
                    Name = "New publisher"
                }
            };

            var bookAuthors = new[]
            {
                new Entities.BookAuthor
                {
                    Author = authors[0],
                    Book = books[0]
                },
                new Entities.BookAuthor
                {
                     Author = authors[1],
                    Book = books[1]
                },
                new Entities.BookAuthor
                {
                    Author = authors[0],
                    Book = books[2]
                }
                ,
                new Entities.BookAuthor
                {
                    Author = authors[1],
                    Book = books[2]
                }
            };

            var bookPublishers = new[]
            {
                new Entities.BookPublisher
                {
                    Book = books[0],
                    Publisher = publishers[0]
                },
                new Entities.BookPublisher
                {
                    Book = books[1],
                    Publisher = publishers[1]
                },
                new Entities.BookPublisher
                {
                    Book = books[2],
                    Publisher = publishers[1]
                }
            };

            // There is no need to add the authors, books and publisher explicitly because this relationship will insert them automatically.
            context.BookAuthors.AddOrUpdate(bookAuthors);
            context.BookPublishers.AddOrUpdate(bookPublishers);            
        }

        /// <summary>
        /// Seeding all info related to users (user, login, role/permission)
        /// </summary>
        private void SeedUsers(LibraryContext context)
        {

        }
    }
}
