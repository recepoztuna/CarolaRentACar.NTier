using Microsoft.AspNetCore.Mvc;

namespace Carola.WebUI.ViewComponents.CarViewComponents
{
	public class _CarLastImageComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
