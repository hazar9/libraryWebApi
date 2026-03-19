using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. Kategoriler (Seed Data)
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Roman" },
                new Category { Id = 2, Name = "Bilim Kurgu" },
                new Category { Id = 3, Name = "Tarih" },
                new Category { Id = 4, Name = "Yazılım" },
                new Category { Id = 5, Name = "Psikoloji" }
            );

            // 2. Kitaplar (Seed Data)
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Nutuk", Author = "Mustafa Kemal Atatürk", PageCount = 600, PublishDate = new DateTime(1927, 10, 15), CategoryId = 3 },
                new Book { Id = 2, Title = "Şeker Portakalı", Author = "José Mauro de Vasconcelos", PageCount = 182, PublishDate = new DateTime(1968, 1, 1), CategoryId = 1 },
                new Book { Id = 3, Title = "Dune", Author = "Frank Herbert", PageCount = 712, PublishDate = new DateTime(1965, 8, 1), CategoryId = 2 },
                new Book { Id = 4, Title = "Clean Code", Author = "Robert C. Martin", PageCount = 464, PublishDate = new DateTime(2008, 8, 1), CategoryId = 4 },
                new Book { Id = 5, Title = "Suç ve Ceza", Author = "Fyodor Dostoyevski", PageCount = 687, PublishDate = new DateTime(1866, 1, 1), CategoryId = 1 },
                new Book { Id = 6, Title = "1984", Author = "George Orwell", PageCount = 328, PublishDate = new DateTime(1949, 6, 8), CategoryId = 2 },
                new Book { Id = 7, Title = "Sapiens", Author = "Yuval Noah Harari", PageCount = 412, PublishDate = new DateTime(2011, 1, 1), CategoryId = 3 },
                new Book { Id = 8, Title = "Simyacı", Author = "Paulo Coelho", PageCount = 188, PublishDate = new DateTime(1988, 1, 1), CategoryId = 1 },
                new Book { Id = 9, Title = "Atomik Alışkanlıklar", Author = "James Clear", PageCount = 320, PublishDate = new DateTime(2018, 10, 16), CategoryId = 5 },
                new Book { Id = 10, Title = "Kürk Mantolu Madonna", Author = "Sabahattin Ali", PageCount = 160, PublishDate = new DateTime(1943, 1, 1), CategoryId = 1 },
                new Book { Id = 11, Title = "Tutunamayanlar", Author = "Oğuz Atay", PageCount = 724, PublishDate = new DateTime(1971, 1, 1), CategoryId = 1 },
                new Book { Id = 12, Title = "Cesur Yeni Dünya", Author = "Aldous Huxley", PageCount = 272, PublishDate = new DateTime(1932, 1, 1), CategoryId = 2 }
            );
        }
    }
}