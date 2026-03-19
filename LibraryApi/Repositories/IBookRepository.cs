using LibraryApi.Models;

namespace LibraryApi.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<IEnumerable<Book>> GetAllWithCategoryAsync();

        // Pagination, Filter ve Sort için yeni metodumuz
        Task<IEnumerable<Book>> GetBooksAdvancedAsync(string? filterQuery, string? sortBy, int pageNumber, int pageSize);
    }
}