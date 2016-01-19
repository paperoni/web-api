using Paperoni.Data.Common.Projections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Data.Common.Retrievers
{
    public interface IBookRetriever : IRetrieverBase<BookProjection>
    {
    }
}
