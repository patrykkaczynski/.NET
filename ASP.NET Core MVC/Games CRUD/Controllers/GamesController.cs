using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatrykKaczynskiLab5ZadDom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab5ZadDom.Controllers
{
    public class GamesController : Controller
    {
        private readonly DataBaseContext _context;
        public GamesController(DataBaseContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Games.ToList());
        }

        [HttpGet]
        public IActionResult Create( )
        {
            var producers = _context.Producers.ToList();
            var genres = _context.Genres.ToList();
            var modes = _context.Modes.ToList();
            var viewModel = new CreateGameViewModel() { Producers = producers, Genres = genres, Modes = modes };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            _context.Games.Add(game);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var game = _context.Games.FirstOrDefault(m => m.Id.Equals(id));
            var producers = _context.Producers.ToList();
            var genres = _context.Genres.ToList();
            var modes = _context.Modes.ToList();
            var viewModel = new CreateGameViewModel() { Game = game, Producers = producers, Genres = genres, Modes = modes };
            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            var gameFromDb = _context.Games.FirstOrDefault(x => x.Id == game.Id);
            if (ModelState.IsValid)
            {
                gameFromDb.Title = game.Title;
                gameFromDb.YearOfRelease = game.YearOfRelease;
                gameFromDb.ProducerId = game.ProducerId;
                gameFromDb.GenreId = game.GenreId;
                gameFromDb.ModeId = game.ModeId;


                _context.Games.Update(gameFromDb);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(gameFromDb);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var game = _context.Games.Include(m => m.Producer).FirstOrDefault(m => m.Id.Equals(id));

            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            _context.Games.Remove(game);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        
        [HttpGet]
        public ActionResult Details(int id)
        {
            var game = _context.Games.Include(x => x.Producer).Include(x => x.Genre).Include(x => x.Mode).FirstOrDefault(m => m.Id.Equals(id));
            var viewModel = new DetailsGameViewModel() { Game = game };
            return View(viewModel);
        }
    }
}

