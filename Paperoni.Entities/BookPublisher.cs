using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Entities
{
    public class BookPublisher
    {
        public Guid ID { get; set; }
        public Guid BookID { get; set; }
        public Guid PublisherID { get; set; }
    }
}
