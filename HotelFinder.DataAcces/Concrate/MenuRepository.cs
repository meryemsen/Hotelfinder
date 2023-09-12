using HotelFinder.DataAcces.Abstract;
using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelFinder.DataAcces.Concrate
{
    public class MenuRepository : IMenuRepository
    {
        public async Task<List<Menu>> GetAllMenu()
        {
            using (var hotelDbcontext = new HotelDbContext())
            {
                return await hotelDbcontext.Menus.ToListAsync();
            }
        }
    }
}
