using Microsoft.AspNetCore.Mvc;

namespace Carola.WebUI.ViewComponents.CarViewComponents
{
	public class _CarBrandImageComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
