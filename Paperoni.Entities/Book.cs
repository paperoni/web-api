using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Entities
{
    public class Book : IEntity
    {
        public Guid ID { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public string Description { get; set; }

        public DateTime PublishedDate { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }

        public ICollection<BookPublisher> BookPublishers { get; set; }
    }
}
