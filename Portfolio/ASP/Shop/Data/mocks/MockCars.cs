using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car{
                        name = "Tesla Model S",
                        shortDesc="Быстрый автомобиль",
                        longDesc="Красивый, быстрый и очень тихий автомобиль",
                        img="/img/tesla.jpeg",
                        price=45000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car{
                        name = "Ford Fiesta",
                        shortDesc="Тихий и спокойный",
                        longDesc="Удобный автомобиль для городской жизни",
                        img="/img/Ford.jpg",
                        price=11000,
                        isFavorite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car{
                        name = "BMW M3",
                        shortDesc="Дерзкий и стильный",
                        longDesc="Удобный автомобиль для городской жизни",
                        img="/img/BMW.jpg",
                        price=65000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car{
                        name = "Mercedes C class",
                        shortDesc="Уютный и большой",
                        longDesc="Удобный автомобиль для городской жизни",
                        img="/img/Mercedes.jpg",
                        price=40000,
                        isFavorite = true,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car{
                        name = "Nissan Leaf",
                        shortDesc="Бесшумный и экономный",
                        longDesc="Удобный автомобиль для городской жизни",
                        img="/img/Nissan.jpeg",
                        price=14000,
                        isFavorite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavoriteCars { get; set; }

        public Car getObjestCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
