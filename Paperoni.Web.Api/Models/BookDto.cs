using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Paperoni.Web.Api.Models
{
    public class BookDto
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public List<AuthorDto> Authors { get; set; }
    }
}