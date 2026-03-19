namespace LibraryApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }

        // İlişki (Foreign Key - Yabancı Anahtar)
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}