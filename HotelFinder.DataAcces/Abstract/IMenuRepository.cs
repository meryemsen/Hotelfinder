using HotelFinder.Entities;

namespace HotelFinder.DataAcces.Abstract
{
    public interface IMenuRepository
    {
        Task<List<Menu>> GetAllMenu();

    }
}