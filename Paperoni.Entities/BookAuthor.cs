using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Entities
{
    public class BookAuthor
    {        
        [Key, Column(Order = 0)]
        public Guid BookID { get; set; }

        [Key, Column(Order = 1)]
        public Guid AuthorID { get; set; }

        public virtual Author Author { get; set; }

        public virtual Book Book { get; set; }
    }
}
