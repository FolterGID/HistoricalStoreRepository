using HistoricalStore.Data.Models.ProductModels;
using HistoricalStore.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace HistoricalStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponController(ICrudService<Weapon> crudService) : BaseProductController<Weapon>(crudService)
    {
        
    }
}
