using Paperoni.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Services.Interfaces
{
    public interface IBookManager
    {
        void AddNewBook(Book book);
        void UpdateBook(Book book);
    }
}
