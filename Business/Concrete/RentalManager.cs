using Business.Abstract;
using Core.Utilities.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Core.Utilities.Concrete;
using Business.Constans;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);

        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.CarsListes);
        }

        public IDataResult<Rental> GetByCustomerId(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(c => c.CustomerId == id), Messages.CarsListes);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.UserAdded);
        }
    }
}
