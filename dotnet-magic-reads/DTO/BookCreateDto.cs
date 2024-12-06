namespace dotnet_magic_reads.DTO
{
    public class BookCreateDto
    {
        public required string Name { get; set; }
        public required double Price { get; set; }
        public required int Stock { get; set; }
        public required string Category { get; set; }
        public string? Img { get; set; }
    }
}
