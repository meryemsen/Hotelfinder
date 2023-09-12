using HotelFinder.DataAcces.Abstract;
using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAcces.Concrate
{
    public class RoomRepository : IRoomRepository
    {
        //public async Task<Room> CreateHotel(Room hotel)
        //{
        //    using (var hotelDbcontext = new HotelDbContext())
        //    {
        //        hotelDbcontext.Rooms.Add(hotel);
        //        await hotelDbcontext.SaveChangesAsync();
        //        return hotel;
        //    }
        //}

        //public async Task DeleteHotel(int id)
        //{
        //    using (var hotelDbcontext = new HotelDbContext())
        //    {
        //        var deletedHotel = await GetHotelsById(id);
        //        hotelDbcontext.Rooms.Remove(deletedHotel);
        //        await hotelDbcontext.SaveChangesAsync();
        //    }
        //}

        public async Task<List<Room>> GetAllRooms()
        {
            using (var hotelDbcontext = new HotelDbContext())
            {
                return await hotelDbcontext.Rooms.ToListAsync();
            }
        }

        //public async Task<Room> GetHotelsById(int id)
        //{
        //    using (var hotelDbcontext = new HotelDbContext())
        //    {
        //        return await hotelDbcontext.Rooms.FindAsync(id);
        //    }
        //}
        //public async Task<Room> GetHotelByName(string name)
        //{
        //    using (var hotelDbcontext = new HotelDbContext())
        //    {
        //        return await hotelDbcontext.Rooms.FirstOrDefaultAsync();
        //    }
        //}
        //public async Task<Room> UpdateHotel(Room hotel)
        //{


        //    using (var hotelDbcontext = new HotelDbContext())
        //    {
        //        hotelDbcontext.Rooms.Update(hotel);
        //        await hotelDbcontext.SaveChangesAsync();
        //        return hotel;
        //    }



        //}
    }
}
