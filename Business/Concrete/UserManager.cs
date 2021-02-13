using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using Core.DataAccsess;
using Core.EntitiyFreamework;
using Core.Entities;
using Entities.Concrete;
using Business.Constans;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccsess.Abstract;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _user;

        public UserManager(IUserDal user)
        {
            _user = user;
        }

        public IResult Add(User user)
        {
            
            if (user.FirstName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _user.Add(user);
            return new SuccessResult(Messages.UserAdded);
            
            

        }

        public IResult Delete(User user)
        {
            _user.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }


        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_user.GetAll(), Messages.UsersListes);
          
        }

        public IDataResult<User> GetByUserId(int id)
        {
            return new SuccessDataResult<User>(_user.Get(u => u.Id == id), Messages.UsersListes);
        }

        public IResult Update(User user)
        {
            _user.Update(user);
            return new SuccessResult(Messages.UserUpdated);
            //Console.WriteLine("güncellendi...");

        }
    }
}
