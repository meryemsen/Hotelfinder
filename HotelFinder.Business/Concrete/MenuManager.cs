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
    public class MenuManager : IMenuService
    {
        private IMenuRepository _menuRepository;

        public MenuManager(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public async Task<List<Menu>> GetAllMenu()
        {
            return await _menuRepository.GetAllMenu();
        }
    }
}
