using Microsoft.AspNetCore.Mvc;
using OutdoorProducts.Models;

namespace OutdoorProducts.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public HomeController( IStoreRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index() => View(repository.Products);

    }
}
