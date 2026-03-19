using LibraryApi.Models;

namespace LibraryApi.Repositories
{
    // Kategorilere özel işlemler gerekirse buraya eklenecek
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category?> GetByIdWithBooksAsync(int id);
    }
}