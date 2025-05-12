using EastParts.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EastPartsBulgaria.Controllers
{
	public class PartTypeController : Controller
	{
		private readonly EastPartsDbContext dbContext;

        public PartTypeController(EastPartsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
		{
			var partTypes = dbContext.PartTypes.Include(pt => pt.PartCategory).ToList();
			return View("~/Views/PartType/Index.cshtml", partTypes);
		}
	}
}
