using Paperoni.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Data.Common
{
    public interface IAuthorRepository : IEntityRepository<Guid, Author>
    {

    }
}
