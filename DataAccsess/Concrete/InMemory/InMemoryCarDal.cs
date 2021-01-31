﻿using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccsess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {

                new Car{Id=1,BrandId=1, ColorId=1, ModelYear=2018, DailyPrice=250000, Description="Doktordan :)" },
                new Car{Id=2,BrandId=1, ColorId=2, ModelYear=2019, DailyPrice=225000, Description="Doktordan :)" },
                new Car{Id=3,BrandId=1, ColorId=2, ModelYear=2020, DailyPrice=355000, Description="Doktordan :)" },
                new Car{Id=4,BrandId=1, ColorId=3, ModelYear=2017, DailyPrice=145000, Description="Doktordan :)" },
                new Car{Id=5,BrandId=1, ColorId=1, ModelYear=2018, DailyPrice=235000, Description="Doktordan :)" },
            
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

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}