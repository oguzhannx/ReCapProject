using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal, IEnumerable
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1 ,BrandId = 1, ColorId = 1, DailyPrice = 500000, ModelYear = 2016, Description = "Mercedes 1"},
                new Car{Id = 2 ,BrandId = 1, ColorId = 2, DailyPrice = 550000, ModelYear = 2016, Description = "Mercedes 2"},
                new Car{Id = 3 ,BrandId = 2, ColorId = 1, DailyPrice = 600000, ModelYear = 2021, Description = "BMW 1"},
                new Car{Id = 4 ,BrandId = 2, ColorId = 2, DailyPrice = 660000, ModelYear = 2021, Description = "BMW 2"},
                new Car{Id = 5 ,BrandId = 3, ColorId = 3, DailyPrice = 800000, ModelYear = 2020, Description = "Dodge 1"},
                new Car{Id = 6 ,BrandId = 3, ColorId = 1, DailyPrice = 800000, ModelYear = 2020, Description = "Dodge 2"},

            };
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
