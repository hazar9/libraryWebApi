using LibraryApi.Data;
using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(LibraryDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Book>> GetAllWithCategoryAsync()
        {
            return await _context.Books.Include(b => b.Category).ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetBooksAdvancedAsync(string? filterQuery, string? sortBy, int pageNumber, int pageSize)
        {
            var query = _context.Books.Include(b => b.Category).AsQueryable();

            // 1. Filtreleme (Başlık veya Yazar adına göre)
            if (!string.IsNullOrWhiteSpace(filterQuery))
            {
                query = query.Where(x => x.Title.Contains(filterQuery) || x.Author.Contains(filterQuery));
            }

            // 2. Sıralama ("title" veya "date" parametresine göre)
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.Equals("title", StringComparison.OrdinalIgnoreCase))
                    query = query.OrderBy(x => x.Title);
                else if (sortBy.Equals("date", StringComparison.OrdinalIgnoreCase))
                    query = query.OrderByDescending(x => x.PublishDate);
            }

            // 3. Sayfalama (Skip ve Take ile)
            var skipResults = (pageNumber - 1) * pageSize;
            return await query.Skip(skipResults).Take(pageSize).ToListAsync();
        }
    }
}