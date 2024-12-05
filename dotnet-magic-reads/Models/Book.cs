using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace dotnet_magic_reads.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required double Price { get; set; }
        public required int Stock { get; set; }
        public required string Category { get; set; }
        public string? Img { get; set; }
    }
}
