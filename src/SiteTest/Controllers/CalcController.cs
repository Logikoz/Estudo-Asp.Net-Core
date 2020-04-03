using Microsoft.AspNetCore.Mvc;

namespace SiteTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test(int value) => Ok(value * 2);

        [HttpGet("Red")]
        public IActionResult Redirect() => RedirectToAction(nameof(HomeController.Privacy), GetController<HomeController>());

        private string GetController<T>() where T : Controller => typeof(T).Name.Replace(nameof(Controller), string.Empty);
    }
}