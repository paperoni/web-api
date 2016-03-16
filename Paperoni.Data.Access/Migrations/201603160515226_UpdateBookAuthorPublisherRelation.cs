namespace Paperoni.Data.Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBookAuthorPublisherRelation : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.BookAuthors");
            DropPrimaryKey("dbo.BookPublishers");
            AddPrimaryKey("dbo.BookAuthors", new[] { "BookID", "AuthorID" });
            AddPrimaryKey("dbo.BookPublishers", new[] { "BookID", "PublisherID" });
            CreateIndex("dbo.BookAuthors", "BookID");
            CreateIndex("dbo.BookAuthors", "AuthorID");
            CreateIndex("dbo.BookPublishers", "BookID");
            CreateIndex("dbo.BookPublishers", "PublisherID");
            AddForeignKey("dbo.BookAuthors", "AuthorID", "dbo.Authors", "ID", cascadeDelete: true);
            AddForeignKey("dbo.BookAuthors", "BookID", "dbo.Books", "ID", cascadeDelete: true);
            AddForeignKey("dbo.BookPublishers", "BookID", "dbo.Books", "ID", cascadeDelete: true);
            AddForeignKey("dbo.BookPublishers", "PublisherID", "dbo.Publishers", "ID", cascadeDelete: true);
            DropColumn("dbo.BookAuthors", "ID");
            DropColumn("dbo.BookPublishers", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookPublishers", "ID", c => c.Guid(nullable: false));
            AddColumn("dbo.BookAuthors", "ID", c => c.Guid(nullable: false));
            DropForeignKey("dbo.BookPublishers", "PublisherID", "dbo.Publishers");
            DropForeignKey("dbo.BookPublishers", "BookID", "dbo.Books");
            DropForeignKey("dbo.BookAuthors", "BookID", "dbo.Books");
            DropForeignKey("dbo.BookAuthors", "AuthorID", "dbo.Authors");
            DropIndex("dbo.BookPublishers", new[] { "PublisherID" });
            DropIndex("dbo.BookPublishers", new[] { "BookID" });
            DropIndex("dbo.BookAuthors", new[] { "AuthorID" });
            DropIndex("dbo.BookAuthors", new[] { "BookID" });
            DropPrimaryKey("dbo.BookPublishers");
            DropPrimaryKey("dbo.BookAuthors");
            AddPrimaryKey("dbo.BookPublishers", "ID");
            AddPrimaryKey("dbo.BookAuthors", "ID");
        }
    }
}
