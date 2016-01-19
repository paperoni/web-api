using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Entities
{
    public class Author
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
    }
}
