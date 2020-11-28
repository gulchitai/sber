using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailOrchestra.WebApp.Controllers
{
	public class HomeController : Controller
	{


		//[HttpGet("{id}")]
		[HttpPost()]
		[ProducesResponseType(StatusCodes.Status200OK)]
		//[ProducesResponseType(StatusCodes.Status404NotFound)]
		public IActionResult LoadData()
		{
			//if (!_repository.TryGetProduct(id, out var product))
			//{
			//	return NotFound();
			//}
			return Ok();
		}

		public IActionResult Index()
		{
			//throw new System.NotImplementedException();
			return View();
		}
	}


}