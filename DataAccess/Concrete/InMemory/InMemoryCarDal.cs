using DataAccess.Abstract;
using Entitiess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{CarId=1, BrandId=1,ColorId=1,ModelYear="2015",DailyPrice=150000,Description="araba"},
                new Car{CarId=2, BrandId=1,ColorId=1,ModelYear="2016",DailyPrice=500000,Description="araba"},
                new Car{CarId=3, BrandId=2,ColorId=1,ModelYear="2015",DailyPrice=150000,Description="araba"},
                new Car{CarId=4, BrandId=2,ColorId=1,ModelYear="2014",DailyPrice=850000,Description="araba"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {    
            // burada firstordefault da kullanılabilir.
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByCategory(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            
        }
    }
}
