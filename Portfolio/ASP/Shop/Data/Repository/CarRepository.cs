using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent _appDBContent;
        public CarRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }
        public IEnumerable<Car> Cars => _appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavoriteCars => _appDBContent.Car.Where(p => p.isFavorite).Include(c => c.Category);

        public Car getObjestCar(int carId) => _appDBContent.Car.FirstOrDefault(b => b.id == carId);
    }
}
