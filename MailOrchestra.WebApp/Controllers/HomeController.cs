using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailOrchestra.WebApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}


	}


}