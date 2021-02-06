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
            _cars = new List<Car> {
            new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice=5000, ModelYear=2010, Description="Manuel"},
            new Car{CarId=2, BrandId=7, ColorId=8, DailyPrice=10000, ModelYear=2021, Description="Otomatik"},
            new Car{CarId=3, BrandId=1, ColorId=5, DailyPrice=2000, ModelYear=1999, Description="Manuel"},
            new Car{CarId=4, BrandId=9, ColorId=4, DailyPrice=7000, ModelYear=2012, Description="Yarı Otomatik"},
            new Car{CarId=5, BrandId=7, ColorId=9, DailyPrice=9000, ModelYear=2019, Description="Otomatik"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        { 
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.CarId = car.CarId;
            
        }
    }
}
