using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatrykKaczynskiLab5ZadDom.Models;

namespace PatrykKaczynskiLab5ZadDom.Controllers
{
    public class ProducersController : Controller
    {
        private readonly DataBaseContext _context;

        public ProducersController(DataBaseContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Producers.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producer producer)
        {
            _context.Producers.Add(producer);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var producer = _context.Producers.Include(m => m.Games).FirstOrDefault(d => d.Id.Equals(id));

            if (producer == null)
            {
                return NotFound();
            }
            return View(producer);
        }

        [HttpPost]
        public IActionResult Delete(Producer producer)
        {
            _context.Games.RemoveRange(_context.Games.Where(m => m.Producer.Equals(producer)));
            _context.Producers.Remove(producer);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
