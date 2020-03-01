using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TODOApp.Contexts;
using TODOApp.Models;
using TODOApp.Models.db;

namespace TODOApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly TodoContext Context;

        public HomeController(TodoContext context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            return View(Context.Todos);
        }

        public IActionResult Add(Todo todo)
        {
            Context.Todos.Add(todo);
            Context.SaveChanges();

            return Redirect("/");
        }

        public IActionResult Update(Todo todo)
        {
            Context.Todos.Update(todo);
            Context.SaveChanges();

            return Redirect("/");
        }

        public IActionResult Delete(int id)
        {
            Context.Todos.Remove(Context.Todos.FirstOrDefault(o => o.Id == id));
            Context.SaveChanges();

            return Redirect("/");
        }
    }
}
