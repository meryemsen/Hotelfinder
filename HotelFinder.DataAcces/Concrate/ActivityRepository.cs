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
    public class ActivityRepository : IActivityRepository
    {
        public async Task<List<Activity>> GetAllActivity()
        {
            using (var hotelDbcontext = new HotelDbContext())
            {
                return await hotelDbcontext.Activities.ToListAsync();
            }
        }
    }
}
