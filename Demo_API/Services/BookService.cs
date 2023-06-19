using System;
using Demo_API.Interfaces;
using Demo_API.Models;

namespace Demo_API.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _bookRepository.GetBooks();
        }

        public async Task<Book> GetBook(int id)
        {
            return await _bookRepository.GetBook(id);
        }

        public async Task CreateBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }
            await _bookRepository.CreateBook(book);
        }

        public async Task UpdateBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }
            await _bookRepository.UpdateBook(book);
        }

        public async Task DeleteBook(int id)
        {
            await _bookRepository.DeleteBook(id);
        }
    }

}

