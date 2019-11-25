using System.ComponentModel.DataAnnotations;

namespace Books_WebAPI.Model
{
    public class Books
    {
        [Key]
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }

        public int PublishYear { get; set; }
        public decimal Price { get; set; }
    }
}
