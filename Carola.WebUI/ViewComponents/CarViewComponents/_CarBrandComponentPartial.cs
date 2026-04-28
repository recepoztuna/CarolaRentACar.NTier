using Microsoft.AspNetCore.Mvc;

namespace Carola.WebUI.ViewComponents.CarViewComponents
{
	public class _CarBrandComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
