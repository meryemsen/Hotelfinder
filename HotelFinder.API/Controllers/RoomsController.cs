using HotelFinder.Business.Abstract;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private IRoomService _roomService;

        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;

        }
        /// <summary>
        /// Get All Hotels
        /// </summary>
        /// <returns></returns>



        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var hotels = await _roomService.GetAllRooms();
            return Ok(hotels); //200 + data
        }
        ///// <summary>
        ///// Get Hotel By Id
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>

        //[HttpGet]
        //[Route ("[action]/{id}")] //api/hotels/gethotelbyid/2
        //public async Task<IActionResult> GetHotelById(int id)
        //{
        //    var hotel = await _hotelService.GetHotelById(id);
        //    if (hotel != null)
        //    {
        //        return Ok(hotel); //200 + data
        //    }
        //    return NotFound(); //404
        //}

        //[HttpGet()]
        //[Route("[action]/{name}")]
        //public async Task<IActionResult> GetHotelByName(string name)
        //{
        //    var hotel= await _hotelService.GetHotelByName(name);
        //    if (hotel != null)
        //    {
        //        return Ok(hotel); //200 + data
        //    }
        //    return NotFound();
        //}
        //[HttpGet()]
        //[Route("[action]")]
        //public async Task<IActionResult> GetHotelByIdAndName(int Id,string name)
        //{
           
        //        return Ok();
           
        //}


        ///// <summary>
        ///// Create an Hotel
        ///// </summary>
        ///// <param name="hotel"></param>
        ///// <returns></returns>

        //[HttpPost]
        //[Route("action")]
        //public async Task<IActionResult> CreateHotel([FromBody] Room hotel)
        //{
            
            
        //        var createdHotel= await _hotelService.CreateHotel(hotel);
        //        return CreatedAtAction("Get", new { id = createdHotel.Id }, createdHotel); //201 + data
            

           
        //}

        ///// <summary>
        ///// Update the Hotel
        ///// </summary>
        ///// <param name="hotel"></param>
        ///// <returns></returns>

        //[HttpPut]
        //[Route("action")]
        //public async Task<IActionResult> Updatehotel([FromBody] Room hotel)
        //{
        //    if(await _hotelService.GetHotelById(hotel.Id)!=null)
        //    {

        //        return Ok(await _hotelService.UpdateHotel(hotel)); //200 + data

        //    }
        //    return NotFound();
        //}

        ///// <summary>
        ///// Delete the Hotel
        ///// </summary>
        ///// <param name="id"></param>

        //[HttpDelete]
        //[Route("[action]/{id}")]
        //public async Task<IActionResult> DeleteHotel(int id)
        //{
        //    if(await _hotelService.GetHotelById(id)!=null)
        //    {
        //        await _hotelService.DeleteHotel(id);
        //        return Ok (); //200
        //    }
        //    return NotFound();
        //}

    }
     
}
