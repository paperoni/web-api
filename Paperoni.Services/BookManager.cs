using Paperoni.Data.Common;
using Paperoni.Data.Common.Retrievers;
using Paperoni.Entities;
using Paperoni.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperoni.Services
{
    public class BookManager : IBookManager
    {
        IBookRepository _bookRepository;
        IAuthorRepository _authorRepository;
        IBookAuthorRepository _bookAuthorRepository;
        public BookManager(IBookRepository bookRepository, IAuthorRepository authorRepository, IBookAuthorRepository bookAuthorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _bookAuthorRepository = bookAuthorRepository;
        }

        public void AddNewBook(Book book)
        {
            _bookRepository.Add(book);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.Update(book);
        }
        
        public Book GetBookByID(Guid id)
        {
            return _bookRepository.GetByID(id);
        }

        public IEnumerable<Author> GetAuthorsByBookId(Guid id)
        {
            return _bookAuthorRepository.GetByBookID(id).Select(o => _authorRepository.GetByID(o.AuthorID));
        }
    }
}
