using HistoricalStore.Data.Models.ProductModels;
using HistoricalStore.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace HistoricalStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseProductController<T>(ICrudService<T> crudService) : Controller where T : Product
    {
        private readonly ICrudService<T> _crudService = crudService;

        // GET: api/{model}
        [HttpGet]
        public async Task<IActionResult> GetAllProducts() => Ok(await _crudService.GetAllItems());


        // GET: api/{model}/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id) =>
            await _crudService.GetOneItem(id) is T product ? Ok(product) : NotFound();
        

        // POST: api/{model}
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] T product)
        {
            await _crudService.AddItem(product);
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }

        // PUT: api/{model}/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct([FromBody] T product)
        {
            await _crudService.UpdateItem(product);
            return NoContent();
        }   


        // DELETE: api/{model}/{id}}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (await _crudService.GetOneItem(id) == null) return NotFound();
            await _crudService.DeleteItem(id);
            return NoContent();
        }
    }
}
