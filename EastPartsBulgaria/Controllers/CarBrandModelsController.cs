using EastParts.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EastPartsBulgaria.Controllers
{
    public class CarBrandModelsController : Controller
    {
        private readonly EastPartsDbContext dbContext;
        public CarBrandModelsController(EastPartsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var carBrandModels = this.dbContext.CarModels.Include(cbm => cbm.CarBrand).ToList();
            return View("~/Views/CarBrandModels/Index.cshtml", carBrandModels);
        }
    }
}
