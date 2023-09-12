using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Abstract
{
    public interface IRoomService
    {
       Task<List<Room>> GetAllRooms();

       //Task<Room> GetHotelById(int id);

       // Task<Room> GetHotelByName(string name);


       // Task<Room> CreateHotel(Room hotel);

       // Task<Room> UpdateHotel(Room hotel); 
        
       //Task DeleteHotel(int id);
    }
}
