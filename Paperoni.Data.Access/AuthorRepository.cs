using Paperoni.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paperoni.Entities;

namespace Paperoni.Data.Access
{
    public class AuthorRepository : EntityRepository<Guid, Author>, IAuthorRepository
    {
        public AuthorRepository(ILibraryContext libraryContext) : base(libraryContext) { }
    }
}
