namespace LibraryApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Bire-Çok İlişki: Bir kategorinin birden fazla kitabı olabilir
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}