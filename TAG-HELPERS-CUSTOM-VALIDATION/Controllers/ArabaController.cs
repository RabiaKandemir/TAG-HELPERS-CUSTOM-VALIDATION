using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TAG_HELPERS_CUSTOM_VALIDATION.Models;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Controllers
{
	public class ArabaController : Controller
	{
		private readonly ILogger<ArabaController> _logger;

		public ArabaController(ILogger<ArabaController> logger)
		{
			_logger = logger;
		}
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}
		public IActionResult ArabaDetails()
		{
			ViewBag.postback = "Araba";
			return View(new Araba());
		}

		[HttpPost]
		public IActionResult ArabaDetails(Araba araba)
		{
			return View(araba);
		}
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
