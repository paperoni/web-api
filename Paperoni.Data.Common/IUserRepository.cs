using Paperoni.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Data.Common
{
    public interface IUserRepository : IEntityRepository<Guid, User>
    {
        User GetByUserName(string userName);

        ContactInfo GetContactInfoByUserID(Guid userID);
    }
}
