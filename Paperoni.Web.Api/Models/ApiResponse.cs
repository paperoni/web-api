using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Paperoni.Web.Api.Models
{
    public class ApiResponse<TData>
    {
        public TData Data { get; set; }
        public string Error { get; set; }
    }
}