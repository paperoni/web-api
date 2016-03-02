using Paperoni.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Data.Access
{
    public abstract class EntityRepository<TKey, TEntity> : IEntityRepository<TKey, TEntity>
        where TEntity : class, new()
    {
        ILibraryContext _libraryContext;
        private List<string> KeyNames { get; set; }
        //private Func<TEntity, TKey> GetKeyValueDelegate { get; set; }

        public EntityRepository(ILibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
            
            var objectSet = _libraryContext.ObjectContext.CreateObjectSet<TEntity>();
            KeyNames = objectSet.EntitySet.ElementType.KeyMembers.Select(k => k.Name).ToList();

            //var keyName = KeyNames.FirstOrDefault();
            //var method = typeof(TEntity).GetProperty(keyName).GetGetMethod(true);
            //GetKeyValueDelegate = (Func<TEntity, TKey>)Delegate.CreateDelegate(typeof(Func<TEntity, TKey>), method);
        }

        public void Add(TEntity entity)
        {
            _libraryContext.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _libraryContext.Update(entity);
        }

        public TEntity GetByID(TKey id)
        {
            if (KeyNames.Count == 0 || KeyNames.Count > 1)
                throw new InvalidOperationException(string.Format("{0} cannot be invoked because entity has zero or more than one key defined.", "GetByID"));

            var whereExpression = CreateFindByIDExpression(id);
            return _libraryContext.GetObjectQuery<TEntity>().FirstOrDefault(whereExpression);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _libraryContext.GetObjectQuery<TEntity>().AsEnumerable();
        }

        public void DeleteByID(TKey id)
        {
            var entity = GetByID(id);
            Remove(entity);
        }

        public void Remove(TEntity entity)
        {            
            if (entity != null)
            {
                _libraryContext.Remove(entity);
            }
        }

        protected virtual Expression<Func<TEntity, bool>> CreateFindByIDExpression(TKey keyValue)
        {
            var paramExpression = Expression.Parameter(typeof(TEntity));
            var keyName = KeyNames.FirstOrDefault();

            var leftExpression = Expression.PropertyOrField(paramExpression, keyName);
            var rightExpression = Expression.Constant(keyValue);
            var equalExp = Expression.Equal(leftExpression, rightExpression);
            var resultingExpression = Expression.Lambda<Func<TEntity, bool>>(equalExp, paramExpression);

            return resultingExpression;
        }
    }
}
