using HotelFinder.Business.Abstract;
using HotelFinder.DataAcces.Abstract;
using HotelFinder.DataAcces.Concrate;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Concrete
{
    public class ActivityManager : IActivityService
    {
        private IActivityRepository _activityRepository;

        public ActivityManager(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        public async Task<List<Activity>> GetAllActivity()
        {
            return await _activityRepository.GetAllActivity();
        }

    }
}
