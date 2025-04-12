using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers
{
    public class TodoController:Controller
    {
        private static List<TodoItem> _tasks = new List<TodoItem>();

        public IActionResult Index()
        {
            return View(_tasks);
        }

        [HttpPost]
        public IActionResult Add(string task)
        {
            if (!string.IsNullOrEmpty(task))
            {
                _tasks.Add(new TodoItem { Task = task });
            }
            return RedirectToAction("Index");
        }
    }

}
