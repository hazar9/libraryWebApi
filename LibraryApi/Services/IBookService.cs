using LibraryApi.Models;

namespace LibraryApi.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();
        Task<Book?> GetBookByIdAsync(int id);
        Task<Book> AddBookAsync(Book book);
        Task UpdateBookAsync(Book book);
        Task DeleteBookAsync(int id);

        // Yeni metodumuz
        Task<IEnumerable<Book>> GetBooksAdvancedAsync(string? filter, string? sortBy, int pageNumber, int pageSize);
    }
}