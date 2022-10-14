using BlogOdevi.GenericRepositoryPattern.IntRepository;
using BlogOdevi.Models.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace BlogOdevi.Controllers
{
    public class UserController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
