using LibraryApi.Models;
using LibraryApi.Repositories;
using Microsoft.Extensions.Logging;

namespace LibraryApi.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly ILogger<BookService> _logger; // log nesnesi

        public BookService(IBookRepository bookRepository, ILogger<BookService> logger)
        {
            _bookRepository = bookRepository;
            _logger = logger;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            _logger.LogInformation("Tüm kitaplar listelendi.");
            return await _bookRepository.GetAllWithCategoryAsync();
        }

        public async Task<Book?> GetBookByIdAsync(int id)
        {
            _logger.LogInformation($"ID'si {id} olan kitap getirildi.");
            return await _bookRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Book>> GetBooksAdvancedAsync(string? filter, string? sortBy, int pageNumber, int pageSize)
        {
            _logger.LogInformation($"Gelişmiş arama yapıldı. Filtre: {filter}, Sıralama: {sortBy}");
            return await _bookRepository.GetBooksAdvancedAsync(filter, sortBy, pageNumber, pageSize);
        }

        public async Task<Book> AddBookAsync(Book book)
        {
            await _bookRepository.AddAsync(book);
            await _bookRepository.SaveAsync();

            _logger.LogInformation($"Yeni kitap eklendi: {book.Title} (ID: {book.Id})");
            return book;
        }

        public async Task UpdateBookAsync(Book book)
        {
            _bookRepository.Update(book);
            await _bookRepository.SaveAsync();

            _logger.LogInformation($"Kitap güncellendi. (ID: {book.Id})");
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await _bookRepository.GetByIdAsync(id);
            if (book != null)
            {
                _bookRepository.Delete(book);
                await _bookRepository.SaveAsync();

                _logger.LogInformation($"Kitap silindi. (ID: {id})");
            }
            else
            {
                _logger.LogWarning($"Silinmek istenen kitap bulunamadı. (ID: {id})");
            }
        }
    }
}