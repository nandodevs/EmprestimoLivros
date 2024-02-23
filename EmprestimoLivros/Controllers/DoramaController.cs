
using DoramasControl.Data;
using DoramasControl.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoramasControl.Controllers
{
    public class DoramaController : Controller
    {
        readonly private ApplicationDbContext _db;

        public DoramaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<DoramasModel> doramas = _db.Doramas;

            return View(doramas);
        }

    }
}

