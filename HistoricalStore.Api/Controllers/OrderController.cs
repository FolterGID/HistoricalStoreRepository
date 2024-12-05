using HistoricalStore.Data.Models.OrderModels;
using HistoricalStore.Data.Models.ProductModels;
using HistoricalStore.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HistoricalStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController(ICrudService<Order> orderService, ICrudService<OrderItem> orderItemService, ICrudService<Product> productService) : Controller
    {
        private readonly ICrudService<Order> _orderService = orderService;
        private readonly ICrudService<OrderItem> _orderItemService = orderItemService;
        private readonly ICrudService<Product> _productService = productService;


        // GET: api/order
        [HttpGet]
        public async Task<IActionResult> GetAllOrders() => Ok(await _orderService.GetAllItems());


        // GET: api/order/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            if (await _orderService.GetOneItem(id) is Order order)
            {
                order.OrderItems = (await _orderItemService.GetAllItems(oi => oi.OrderId == order.Id)).ToList();
                foreach (var item in order.OrderItems) item.Product = (await _productService.GetAllItems(p => p.Id == item.ProductId)).FirstOrDefault();
                return Ok(order);
            }

            return NotFound();
        }


        // POST: api/order
        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] Order order)
        {
            if (order.OrderItems == null || order.OrderItems.Count == 0)
                return BadRequest("Заказ должен содержать хотя бы один элемент.");
            await _orderService.AddItem(order);
            return CreatedAtAction(nameof(GetOrderById), new { id = order.Id }, order);
        }


        // PUT: api/order/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, [FromBody] Order updatedOrder)
        {
            if (id != updatedOrder.Id)
                return BadRequest("Идентификатор заказа не совпадает.");

            var order = (await _orderService.GetAllItems(o => o.Id == id)).FirstOrDefault();

            if (order == null) return NotFound();

            // Обновление полей заказа
            order.OrderDate = updatedOrder.OrderDate;
            order.TotalPrice = updatedOrder.TotalPrice;
            order.OrderStatusId = updatedOrder.OrderStatusId;

            // Обновление количества для существующих товаров и добавление новых
            foreach (var updatedItem in updatedOrder.OrderItems)
            {
                var existingItem = order.OrderItems.FirstOrDefault(oi => oi.ProductId == updatedItem.ProductId);

                if (existingItem != null)
                {
                    existingItem.Quantity = updatedItem.Quantity;
                }
                else
                {
                    order.OrderItems.Add(new OrderItem
                    {
                        ProductId = updatedItem.ProductId,
                        Quantity = updatedItem.Quantity
                    });
                }
            }

            // Удаление товаров, которые отсутствуют в обновлённом заказе
            var itemsToRemove = order.OrderItems
                .Where(existingItem => !updatedOrder.OrderItems.Any(updatedItem => updatedItem.ProductId == existingItem.ProductId)).ToList();

            foreach (var itemToRemove in itemsToRemove) order.OrderItems.Remove(itemToRemove);

            await _orderService.UpdateItem(order);
            return NoContent();
        }


        // DELETE: api/orders/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            if (await _orderService.GetOneItem(id) == null)
                return NotFound();

            await _orderService.DeleteItem(id);
            return NoContent();
        }
    }
}
