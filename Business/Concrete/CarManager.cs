﻿using Business.Abstract;
using Business.Constans;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccsess.Abstract;
using DataAccsess.Concrete.EntityFreamwork;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal car)
        {
            _carDal = car;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice < 1)
            {
                new ErrorResult(Messages.CarNameInvalid);

            }

            _carDal.Add(car);
           return new SuccessResult(Messages.CarAdded);
            

        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
            
        }

        public IDataResult<List<Car>>GetAll()
        {
            if (DateTime.Now.Hour == 24)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListes);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {

            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id).ToList(), Messages.CarsListes);
        }


        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id).ToList(), Messages.CarsListes);
        }

       

        public IResult Update(Car car)
        {
            return new SuccessResult(Messages.CarUpdated);
            _carDal.Update(car);
        }

       
    }
}
