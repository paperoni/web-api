using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Data.Common.Projections
{
    public class BookProjection
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }        
        public string Publishers { get; set; }
        public string Authors { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
