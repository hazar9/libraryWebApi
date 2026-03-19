using LibraryApi.Models;
using LibraryApi.Repositories;

namespace LibraryApi.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync() => await _bookRepository.GetAllWithCategoryAsync();

        public async Task<Book?> GetBookByIdAsync(int id) => await _bookRepository.GetByIdAsync(id);

        public async Task<IEnumerable<Book>> GetBooksAdvancedAsync(string? filter, string? sortBy, int pageNumber, int pageSize)
        {
            return await _bookRepository.GetBooksAdvancedAsync(filter, sortBy, pageNumber, pageSize);
        }

        public async Task<Book> AddBookAsync(Book book)
        {
            await _bookRepository.AddAsync(book);
            await _bookRepository.SaveAsync();
            return book;
        }

        public async Task UpdateBookAsync(Book book)
        {
            _bookRepository.Update(book);
            await _bookRepository.SaveAsync();
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await _bookRepository.GetByIdAsync(id);
            if (book != null)
            {
                _bookRepository.Delete(book);
                await _bookRepository.SaveAsync();
            }
        }
    }
}