using Microsoft.AspNetCore.Mvc;

namespace HistoricalStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHomeMessage()
        {
            return Ok("Добро пожаловать на главную страницу исторического магазина!");
        }
    }
}
