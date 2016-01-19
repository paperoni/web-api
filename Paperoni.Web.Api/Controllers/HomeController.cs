using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Paperoni.Web.Api.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public List<string> Index()
        {
            return new List<string>
            {
                "api/book/borrow/{id}",
                "api/book/return/{id}",
                "api/book/add/{book}",
                "api/book/remove/{id}",                
                "api/login/{user}",
                "api/logout/{user}",
                "api/login/token/{token}"
            };
        }
    }
}
