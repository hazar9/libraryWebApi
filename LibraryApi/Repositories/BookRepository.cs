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

            // filtre - ToLower ekledim
            if (!string.IsNullOrWhiteSpace(filterQuery))
            {
                var search = filterQuery.ToLower();
                query = query.Where(x => x.Title.ToLower().Contains(search) ||
                                       x.Author.ToLower().Contains(search));
            }

            // sıralama - sadece 'title' ve 'date' parametresi
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.Equals("title", StringComparison.OrdinalIgnoreCase))
                    query = query.OrderBy(x => x.Title);
                else if (sortBy.Equals("date", StringComparison.OrdinalIgnoreCase))
                    query = query.OrderByDescending(x => x.PublishDate);
            }

            // pagecount ve pagesize
            var skipResults = (pageNumber - 1) * pageSize;
            return await query.Skip(skipResults).Take(pageSize).ToListAsync();
        }
    }
}