using EastParts.Data;
using EastParts.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static EastParts.Common.EntityValidationConstants;

namespace EastPartsBulgaria.Controllers
{
    public class PartCategoryController : Controller
    {
        private readonly EastPartsDbContext dbContext;

        public PartCategoryController(EastPartsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
			var partCategories = dbContext.PartCategories.ToList();
            return View("~/Views/PartCategory/Index.cshtml", partCategories);
        }
    }
}
