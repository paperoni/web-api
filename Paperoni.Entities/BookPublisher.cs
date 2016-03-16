using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Entities
{
    public class BookPublisher
    {
        [Key, Column(Order = 0)]
        public Guid BookID { get; set; }

        [Key, Column(Order = 1)]
        public Guid PublisherID { get; set; }

        public virtual Book Book { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}
