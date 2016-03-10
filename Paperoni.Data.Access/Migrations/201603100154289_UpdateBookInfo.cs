namespace Paperoni.Data.Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBookInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookPublishers",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        BookID = c.Guid(nullable: false),
                        PublisherID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Books", "PublishedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "PublishedDate");
            DropTable("dbo.Publishers");
            DropTable("dbo.BookPublishers");
        }
    }
}
