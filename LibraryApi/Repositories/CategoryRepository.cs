using LibraryApi.Data;
using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(LibraryDbContext context) : base(context)
        {
        }

        public async Task<Category?> GetByIdWithBooksAsync(int id)
        {
            // Kategoriyi çekerken o kategoriye ait kitapları da getiriyoruz
            return await _context.Categories
                .Include(c => c.Books)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
        //düzeltme 
        public async Task<IEnumerable<Category>> GetAllWithBooksAsync()
        {
            return await _context.Categories
                .Include(c => c.Books)
                .ToListAsync();
        }
    }
}