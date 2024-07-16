using Microsoft.AspNetCore.Mvc;
using Avl1.Models;
using System.Collections.Generic;

namespace Avl1.Controllers
{
    public class MessageController : Controller
    {
        private static List<Message> messages = new List<Message>();

        [HttpGet]
        public IActionResult Index()
        {
            return View(messages);
        }

        [HttpPost]
        public IActionResult Index(Message message)
        {
            messages.Add(message);
            return RedirectToAction("Index");
        }
    }
}
