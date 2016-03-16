using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Entities
{
    public class ContactInfo : IEntity
    {
        public Guid ID { get; set; }

        public Guid UserID { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PostCode { get; set; }

        public virtual User User { get; set; }
    }
}
