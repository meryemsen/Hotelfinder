using HotelFinder.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private IActivityService _ActivityService;
       

        public ActivityController(IActivityService ActivityService)
        {
            _ActivityService = ActivityService;

        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var hotels = await _ActivityService.GetAllActivity();
            return Ok(hotels); //200 + data
        }
    }
}
