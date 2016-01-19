using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace Paperoni.Data.Common
{
    public interface ILibraryContext : IObjectContextAdapter
    {
        IQueryable<TEntity> GetObjectQuery<TEntity>() where TEntity : class, new();
        void Insert<TEntity>(TEntity entity) where TEntity : class, new();
        void Update<TEntity>(TEntity entity) where TEntity : class, new();
        void Remove<TEntity>(TEntity entity) where TEntity : class, new();
        void SaveChanges();
    }
}
