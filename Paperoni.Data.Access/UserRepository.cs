using Paperoni.Data.Common;
using Paperoni.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Data.Access
{
    public class UserRepository : EntityRepository<Guid, User>, IUserRepository
    {
        public UserRepository(ILibraryContext libraryContext)
            : base(libraryContext)
        {

        }

        public User GetByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public ContactInfo GetContactInfoByUserID(Guid userID)
        {
            throw new NotImplementedException();
        }
    }
}
