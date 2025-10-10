namespace TutorConnect.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        // Foreign key + relationship
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
