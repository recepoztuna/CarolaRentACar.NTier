using Microsoft.AspNetCore.Mvc;

namespace Carola.WebUI.ViewComponents.CarViewComponents
{
	public class _CarFeatureComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
