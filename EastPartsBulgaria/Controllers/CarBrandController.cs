using EastParts.Data;
using Microsoft.AspNetCore.Mvc;

namespace EastPartsBulgaria.Controllers
{
    public class CarBrandController : Controller
    {
        private readonly EastPartsDbContext dbContext;
        public CarBrandController(EastPartsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var carBrands = this.dbContext.CarBrands.ToList();
            return View("~/Views/CarBrand/Index.cshtml", carBrands);
        }
    }
}
