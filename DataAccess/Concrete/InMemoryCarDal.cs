using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=150, ModelYear=2009, Description="Alfa Romeo"},
                new Car{Id=2, BrandId=2, ColorId=2, DailyPrice=1500, ModelYear=2010, Description="Aston Martin"},
                new Car{Id=3, BrandId=2, ColorId=1, DailyPrice=15000, ModelYear=2011, Description="Audi"},
                new Car{Id=4, BrandId=3, ColorId=2, DailyPrice=15000, ModelYear=2012, Description="Bentley"},
                new Car{Id=5, BrandId=3, ColorId=1, DailyPrice=150000, ModelYear=2018, Description="BMW"},
               
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

       

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.Id == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}