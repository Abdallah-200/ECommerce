using Microsoft.AspNetCore.Mvc;
using ECommerce.Data;

namespace ECommerce.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CartController(ApplicationDbContext db) => _db = db;

        public IActionResult Index()
        {
            // Placeholder: implement session-based or DB-based cart
            return View();
        }
    }
}
