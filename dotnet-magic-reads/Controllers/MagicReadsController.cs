using dotnet_magic_reads.Data.Context;
using dotnet_magic_reads.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_magic_reads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagicReadsController : Controller
    {
        private readonly MagicReadsContext _context;

        public MagicReadsController(MagicReadsContext context)
        {
            _context = context;

            if (!_context.Books.Any())
            {
                _context.Books.AddRange(
                    new Book
                    {
                        Name = "The Standard Book of Spells, Grade 1",
                        Price = 24.99,
                        Stock = 30,
                        Category = "Magic School",
                        Img = "https://example.com/standard_book_of_spells.jpg"
                    },
                    new Book
                    {
                        Name = "Magical Drafts and Potions",
                        Price = 29.99,
                        Stock = 25,
                        Category = "Magic School",
                        Img = "https://example.com/magical_drafts_and_potions.jpg"
                    },
                    new Book
                    {
                        Name = "Fantastic Beasts and Where to Find Them",
                        Price = 34.99,
                        Stock = 40,
                        Category = "Magic School",
                        Img = "https://example.com/fantastic_beasts.jpg"
                    },
                    new Book
                    {
                        Name = "A History of Magic",
                        Price = 39.99,
                        Stock = 20,
                        Category = "Magic School",
                        Img = "https://example.com/history_of_magic.jpg"
                    },
                    new Book
                    {
                        Name = "The Dark Forces: A Guide to Self-Protection",
                        Price = 27.99,
                        Stock = 15,
                        Category = "Magic School",
                        Img = "https://example.com/dark_forces.jpg"
                    }
                );
                _context.SaveChanges();
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            try
            {
                var book = await _context.Books.FindAsync(id);

                if (book == null)
                {
                    return NotFound(new { Message = $"Book with id {id} not found." });
                }

                return Ok(book);
            }
            catch (Exception)
            {
                return StatusCode(500, new { Message = "An error occurred while processing your request." });
            }
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetAllBooks()
        {
            try
            {
                var books = await _context.Books.ToListAsync();

                if (books.Count == 0)
                {
                    return NotFound(new { Message = $"No books were found." });
                }

                return Ok(books);
            }
            catch (Exception)
            {
                return StatusCode(500, new { Message = "An error occurred while processing your request." });
            }
        }

        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book newBook)
        {
            await _context.Books.AddAsync(newBook);
            _context.SaveChanges();
            return Ok(newBook);
        }
    }
}
