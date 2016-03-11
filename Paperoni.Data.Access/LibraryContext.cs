using Paperoni.Data.Common;
using Paperoni.Entities;
using System.Data.Entity;
using System.Linq;
using System;
using System.Data.Entity.Infrastructure.Pluralization;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace Paperoni.Data.Access
{
    public class LibraryContext : System.Data.Entity.DbContext, ILibraryContext
    {
        public LibraryContext()
            : base("Paperoni")
        {

        }

        public IQueryable<TEntity> GetObjectQuery<TEntity>() where TEntity : class, new()
        {
            return Set<TEntity>();
        }

        public void Insert<TEntity>(TEntity newEntity) where TEntity : class, new()
        {
            Set<TEntity>().Add(newEntity);
        }

        public void Update<TEntity>(TEntity modifiedEntity) where TEntity : class, new()
        {
            var typeName = typeof(TEntity).Name;
            var pluralizationService = new EnglishPluralizationService();
            var setName = pluralizationService.Pluralize(typeName);
            GetObjectContext().ApplyCurrentValues(setName, modifiedEntity);
        }

        public void Remove<TEntity>(TEntity entityToRemove) where TEntity : class, new()
        {
            Set<TEntity>().Remove(entityToRemove);
        }

        public ObjectContext GetObjectContext()
        {
            return ((IObjectContextAdapter)this).ObjectContext;
        }

        void ILibraryContext.SaveChanges()
        {
            this.SaveChanges();
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookPublisher> BookPublishers { get; set; }
    }
}
