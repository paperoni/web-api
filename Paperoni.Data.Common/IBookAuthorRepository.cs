using Paperoni.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Data.Common
{
    public interface IBookAuthorRepository : IEntityRepository<Guid, BookAuthor>
    {
        IEnumerable<BookAuthor> GetByBookID(Guid id);
        IEnumerable<BookAuthor> GetByAuthorID(Guid id);
    }
}
