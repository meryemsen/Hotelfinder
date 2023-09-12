using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAcces
{
    public class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-07ATUC3; Database= HotelDb;Integrated Security=True; TrustServerCertificate=True");
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Activity> Activities { get; set; }
       
    }


}
