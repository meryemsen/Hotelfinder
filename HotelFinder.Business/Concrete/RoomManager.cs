using HotelFinder.Business.Abstract;
using HotelFinder.DataAcces.Abstract;
using HotelFinder.DataAcces.Concrate;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Concrete
{
    public class RoomManager : IRoomService
    {
        private IRoomRepository _roomRepository;

        public RoomManager(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        //public async Task<Room> CreateHotel(Room hotel)
        //{
        //    return await _hotelRepository.CreateHotel(hotel);
        //}

        //public async Task DeleteHotel(int id)
        //{
        //    await _hotelRepository.DeleteHotel(id);
        //}

        public async Task<List<Room>> GetAllRooms()
        {
           return await _roomRepository.GetAllRooms();
        }

        //public async Task<Room> GetHotelById(int id)
        //{
        //    if (id > 0)
        //    {
        //        return await _hotelRepository.GetHotelsById(id);
        //    }
        //    throw new Exception("id can not be less than 1"); 
        //}
        //public Task<Room> GetHotelByName(string name)
        //{
        //    return _hotelRepository.GetHotelByName(name);
        //}
        //public async Task<Room> UpdateHotel(Room hotel)
        //{
        //    return await _hotelRepository.UpdateHotel(hotel);
        //}
    }
}