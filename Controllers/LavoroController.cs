using EdiliziaDue.Models;
using Microsoft.AspNetCore.Mvc;

namespace EdiliziaDue.Controllers
{
    public class LavoroController : Controller
    {
        public IActionResult Index()
        {
            return View(DbLavoro.getAll());
        }

        public IActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                return View(DbLavoro.getById(id));
            }
            else
            {
                return RedirectToAction("Index", "Lavoro");
            }
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string periodo, int pagamento, string tipo)
        {
            var lavoro = DbLavoro.AggiungiLavoro(periodo, pagamento, tipo);

            return RedirectToAction("Details", new { id = lavoro.LavoroId });
        }

       








    }
}
