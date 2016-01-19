using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Entities
{
    public class BookAuthor
    {
        public Guid ID { get; set; }
        public Guid BookID { get; set; }
        public Guid AuthorID { get; set; }
    }
}
