using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Data.Common.Retrievers
{
    public interface IRetrieverBase<out TResult>
    {
        IEnumerable<TResult> GetData();

        IQueryable<TResult> GetQuery();
    }
}
