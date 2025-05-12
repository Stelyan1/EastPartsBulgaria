using EastParts.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EastPartsBulgaria.Controllers
{
	public class ProductController : Controller
	{
		private readonly EastPartsDbContext dbContext;

        public ProductController(EastPartsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
		{
			var products = dbContext.Products.Include(p => p.CarBrandModels).ToList();
			return View("~/Views/Product/Index.cshtml", products);
		}
	}
}
