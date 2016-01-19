using Paperoni.Services.Interfaces;
using Paperoni.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Paperoni.Web.Api.Controllers
{
    public class BookController : ApiController
    {
        IBookManager _bookManager;
        public BookController(IBookManager bookManager)
        {
            _bookManager = bookManager;
        }

        [HttpPost]
        public ApiResponse<bool> AddBook(BookDto book)
        {
            // Todo: fix this
            return new ApiResponse<bool>
            {
                Data = true
            };
        }
    }
}