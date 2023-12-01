using IT3045C_Final.Controllers.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IT3045C_Final.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenInfoController : Controller
    {
        private readonly ILogger<GenInfoController> _logger;
        private readonly GenInfoData _context;
        public GenInfoController(ILogger<GenInfoData> logger, GenInfoData context)
        {
            _logger = logger;
            _context = context;
        }
        /* [HttpGet]
         public IActionResult Get() {
             return Ok(_context.Information.ToList());
         }
         // GET: NickBernloehr
         public ActionResult Index()
         {
             return View();
         }

         // GET: NickBernloehr/Details/5
         public ActionResult Details(int id)
         {
             return View();
         }

         // GET: NickBernloehr/Create
         public ActionResult Create()
         {
             return View();
         }

         // POST: NickBernloehr/Create
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Create(IFormCollection collection)
         {
             try
             {
                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }

         // GET: NickBernloehr/Edit/5
         public ActionResult Edit(int id)
         {
             return View();
         }

         // POST: NickBernloehr/Edit/5
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Edit(int id, IFormCollection collection)
         {
             try
             {
                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }

         // GET: NickBernloehr/Delete/5
         public ActionResult Delete(int id)
         {
             return View();
         }

         // POST: NickBernloehr/Delete/5
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Delete(int id, IFormCollection collection)
         {
             try
             {
                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }*/
    }
}
