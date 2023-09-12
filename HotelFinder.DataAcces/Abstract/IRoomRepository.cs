using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAcces.Abstract
{
    public interface IRoomRepository
    {
        Task<List<Room>> GetAllRooms();
        //Task<Room> GetHotelsById(int id);
        //Task<Room> GetHotelByName(string name);
        //Task<Room> CreateHotel(Room hotel);
        //Task<Room> UpdateHotel(Room hotel);
        //Task DeleteHotel(int id);
    }
}
