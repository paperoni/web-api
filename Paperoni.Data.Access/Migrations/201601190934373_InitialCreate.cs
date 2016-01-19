namespace Paperoni.Data.Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        BookID = c.Guid(nullable: false),
                        AuthorID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Title = c.String(),
                        ISBN = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
            DropTable("dbo.BookAuthors");
            DropTable("dbo.Authors");
        }
    }
}
