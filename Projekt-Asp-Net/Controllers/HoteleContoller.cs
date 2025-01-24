using Microsoft.AspNetCore.Mvc;
using ProjektAspNet.Models.Entities;

namespace ProjektAspNet.Controllers
{
    public class HoteleController : Controller
    {
        private static List<Hotel> hotele = new List<Hotel>
        {
            new Hotel { Id = 1, Nazwa = "Hotel Sunshine", Lokalizacja = "Warszawa", CenaZaNoc = 300, DostępnePokoje = 10 },
            new Hotel { Id = 2, Nazwa = "Hotel Seaside", Lokalizacja = "Gdańsk", CenaZaNoc = 400, DostępnePokoje = 5 }
        };

        public IActionResult Index()
        {
            return View(hotele);
        }

        public IActionResult Details(int id)
        {
            var hotel = hotele.FirstOrDefault(h => h.Id == id);
            if (hotel == null)
                return NotFound();

            return View(hotel);
        }
    }
}
