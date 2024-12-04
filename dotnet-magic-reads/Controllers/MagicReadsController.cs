using dotnet_magic_reads.Data;
using dotnet_magic_reads.Models;
using Microsoft.AspNetCore.Mvc;

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

            _context.Add(new Book
            {
                Id = 1,
                Name = "The Standard Book of Spells, Grade 1",
                Price = 24.99,
                Stock = 30,
                Category = "Magic School",
                Img = "https://example.com/standard_book_of_spells.jpg"
            });

            _context.Add(new Book
            {
                Id = 2,
                Name = "Magical Drafts and Potions",
                Price = 29.99,
                Stock = 25,
                Category = "Magic School",
                Img = "https://example.com/magical_drafts_and_potions.jpg"
            });

            _context.Add(new Book
            {
                Id = 3,
                Name = "Fantastic Beasts and Where to Find Them",
                Price = 34.99,
                Stock = 40,
                Category = "Magic School",
                Img = "https://example.com/fantastic_beasts.jpg"
            });

            _context.Add(new Book
            {
                Id = 4,
                Name = "A History of Magic",
                Price = 39.99,
                Stock = 20,
                Category = "Magic School",
                Img = "https://example.com/history_of_magic.jpg"
            });

            _context.Add(new Book
            {
                Id = 5,
                Name = "The Dark Forces: A Guide to Self-Protection",
                Price = 27.99,
                Stock = 15,
                Category = "Magic School",
                Img = "https://example.com/dark_forces.jpg"
            });
        }


        // GET: MagicReadsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MagicReadsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MagicReadsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MagicReadsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MagicReadsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MagicReadsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MagicReadsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MagicReadsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
