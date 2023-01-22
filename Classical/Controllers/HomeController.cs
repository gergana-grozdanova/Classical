using Classical.Data;
using Classical.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Classical.Controllers
{
    public class HomeController : Controller
    {
        private readonly ClassicalDbContext _context;
        public HomeController(ClassicalDbContext context)
        {
            _context = context;
        }
        // GET: HomeController
        public ActionResult Index()
        {
          var all=  _context.Element;
            return View(all) ;
        }


        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Element el)
        {
            if (ModelState.IsValid)
            {
                _context.Add(el);
                _context.SaveChanges();
            }
            return  RedirectToAction("Index", "Home");
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(string id)
        {
            var el= _context.Element.FirstOrDefault(e=>e.Id==id);
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string  id, Element el)
        {
            var element = _context.Element.FirstOrDefault(e => e.Id == id);
            element.Name = el.Name;
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Delete(string id)
        {
            var element = _context.Element.FirstOrDefault(e=>e.Id==id);
            _context.Element.Remove(element);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
