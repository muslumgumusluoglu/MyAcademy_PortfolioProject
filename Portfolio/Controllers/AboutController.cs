using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class AboutController : Controller
    {

        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var about = _context.Abouts.FirstOrDefault(); // ilk deger gelecek
            return View(about);
        }


        [HttpGet]
        public IActionResult CreatAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatAbout(About about)
        {
            _context.Abouts.Add(about); 
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
