using Microsoft.AspNetCore.Mvc;

namespace Carola.WebUI.Controllers
{
	public class CarolaController : Controller
	{
		
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult CarList()
		{
			return View();
		}
	}
}
