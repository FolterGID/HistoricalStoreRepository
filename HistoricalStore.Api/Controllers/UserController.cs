using HistoricalStore.Data.Models.UserModels;
using HistoricalStore.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace HistoricalStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(ICrudService<User> crudService) : Controller
    {
        private readonly ICrudService<User> _crudService = crudService;

        // GET: api/user
        [HttpGet]
        public async Task<IActionResult> GetAllUsers() => Ok(await _crudService.GetAllItems());


        // GET: api/user/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _crudService.GetOneItem(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        // POST: api/user
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _crudService.AddItem(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        // PUT: api/user/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(string id, [FromBody] User user)
        {
            if (id != user.Id || !ModelState.IsValid) return BadRequest();
            await _crudService.UpdateItem(user);
            return NoContent();
        }


        // DELETE: api/user/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (await _crudService.GetOneItem(id) == null) return NotFound();
            await _crudService.DeleteItem(id);
            return NoContent();
        }
    }
}
