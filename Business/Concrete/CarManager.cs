using Business.Abstract;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _car;

        public CarManager(ICarDal car)
        {
            _car = car;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _car.Add(car);
            }
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _car.GetAll(c => c.BrandId == id).ToList();
        }

       
        public List<Car> GetCarsByColorId(int id)
        {
            return _car.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
