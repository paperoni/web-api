using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Data.Common
{
    public interface IEntityRepository<TKey, TEntity>
    {
        IEnumerable<TEntity> GetAll();

        void Add(TEntity entity);

        void Update(TEntity entity);

        TEntity GetByID(TKey id);

        void Remove(TEntity entity);
    }
}
