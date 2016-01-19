using Paperoni.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paperoni.Entities;

namespace Paperoni.Data.Access
{
    public class BookAuthorRepository : EntityRepository<Guid, BookAuthor>, IBookAuthorRepository
    {
        public BookAuthorRepository(ILibraryContext libraryContext) : base(libraryContext) { }

        public IEnumerable<BookAuthor> GetByAuthorID(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookAuthor> GetByBookID(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
