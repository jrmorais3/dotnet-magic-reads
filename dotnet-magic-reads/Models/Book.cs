namespace dotnet_magic_reads.Models
{
    public class Book
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required double Price { get; set; }
        public required int Stock { get; set; }
        public required string Category { get; set; }
        public string? Img { get; set; }
    }
}
