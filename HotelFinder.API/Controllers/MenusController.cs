using HotelFinder.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private IMenuService _menuService;

        public MenusController(IMenuService menuService)
        {
            _menuService = menuService;

        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var hotels = await _menuService.GetAllMenu();
            return Ok(hotels); //200 + data
        }
    }
}
