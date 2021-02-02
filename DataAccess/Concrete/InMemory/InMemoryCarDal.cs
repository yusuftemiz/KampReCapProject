using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice=500, ModelYear=1990, Description="Açıklama1"},
                new Car{CarId=2, BrandId=4, ColorId=2, DailyPrice=750, ModelYear=2000, Description="Açıklama2"},
                new Car{CarId=3, BrandId=2, ColorId=1, DailyPrice=1000, ModelYear=2005, Description="Açıklama3"},
                new Car{CarId=4, BrandId=3, ColorId=2, DailyPrice=950, ModelYear=2010, Description="Açıklama4"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int myId)
        {
            return _cars.Where(p => p.CarId == myId).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;

        }
    }
}
