using Microsoft.AspNetCore.Mvc;
using TaskManager.Models.ViewModels;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
