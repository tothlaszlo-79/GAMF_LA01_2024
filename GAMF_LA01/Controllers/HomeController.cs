using GAMF_LA01.Data;
using GAMF_LA01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GAMF_LA01.Controllers
{
    public class HomeController : Controller
    {
        private readonly GAMFDbContext _dbContext;
        public HomeController(GAMFDbContext context) {
            _dbContext = context;
        }

        public IActionResult Index() { 
            var students = _dbContext.Students.ToList();
            return View();
        }
    }
}
