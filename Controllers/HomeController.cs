using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {

        ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        public async Task <IActionResult> ShowOrders()
        {
            return View(await db.Orders.ToListAsync());
        }

        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> CreateOrder(Order order)
        {
            db.Orders.Add(order);
            await db.SaveChangesAsync();
            return RedirectToAction("ShowOrders");
        }

        public IActionResult ShowOrder()
        {
            Order order=new Order();
            int id = int.Parse(HttpContext.Request.Query["id"]);
            order = db.Orders.Find(id);
            return View(order);
        }
    }
}