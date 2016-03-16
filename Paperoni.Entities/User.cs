using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Entities
{
    public class User : IEntity
    {
        public Guid ID { get; set; }
        public string UserName { get; set; }

        public ICollection<ContactInfo> ContactInfos { get; set; }
    }
}
