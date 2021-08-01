using Microsoft.AspNetCore.Mvc;
using PatrykKaczynskiLab5ZadDom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab5ZadDom.Controllers
{
    public class ModesController : Controller
    {
        private readonly DataBaseContext _context;

        public ModesController(DataBaseContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Modes.ToList());
        }
    }
}
