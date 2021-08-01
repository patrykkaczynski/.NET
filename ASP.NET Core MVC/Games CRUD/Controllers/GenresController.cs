using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatrykKaczynskiLab5ZadDom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab5ZadDom.Controllers
{
    public class GenresController : Controller
    {
        private readonly DataBaseContext _context;

        public GenresController(DataBaseContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Genres.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            _context.Genres.Add(genre);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var genre = _context.Genres.Include(m => m.Games).FirstOrDefault(d => d.Id.Equals(id));

            if (genre == null)
            {
                return NotFound();
            }
            return View(genre);
        }

        [HttpPost]
        public IActionResult Delete(Genre genre)
        {
            _context.Games.RemoveRange(_context.Games.Where(m => m.Genre.Equals(genre)));
            _context.Genres.Remove(genre);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
