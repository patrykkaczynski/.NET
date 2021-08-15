using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatrykKaczynskiLab4ZadDom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab4ZadDom.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataBaseContext _context;
        public HomeController(DataBaseContext context)
        {
            this._context = context;
        }
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View(_context.TaskViewModels.Where(x => !x.Done).ToList());
        }

        // GET: Home/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(_context.TaskViewModels.FirstOrDefault(x=>x.TaskId == id));
        }

        // GET: Home/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new TaskViewModel());
        }

        // POST: Home/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaskViewModel taskViewModel)
        {
            taskViewModel.timeCreation = DateTime.Now;
            taskViewModel.timeEdition = DateTime.Now;
            _context.TaskViewModels.Add(taskViewModel);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // GET: Home/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(_context.TaskViewModels.FirstOrDefault(x => x.TaskId == id));
        }

        // POST: Home/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TaskViewModel taskViewModel)
        {
            TaskViewModel task = _context.TaskViewModels.FirstOrDefault(x => x.TaskId == id);
            task.ApplicationName = taskViewModel.ApplicationName;
            task.Title = taskViewModel.Title;
            task.Priority = taskViewModel.Priority;
            task.Description = taskViewModel.Description;
            task.timeEdition = DateTime.Now;
            _context.TaskViewModels.Update(task);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: Home/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_context.TaskViewModels.FirstOrDefault(m => m.TaskId.Equals(id)));
        }

        // POST: Home/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TaskViewModel taskViewModel)
        {
            TaskViewModel task = _context.TaskViewModels.FirstOrDefault(x => x.TaskId == id);
            _context.TaskViewModels.Remove(task);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: Home/Done/5
        [HttpGet]
        public ActionResult Done(int id)
        {
            TaskViewModel task = _context.TaskViewModels.FirstOrDefault(x => x.TaskId == id);
            task.Done = true;
            _context.TaskViewModels.Update(task);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
