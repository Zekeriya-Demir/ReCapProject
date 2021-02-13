using Core.EntitiyFreamework;
using Core.Utilities;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Concrete.EntityFreamwork
{
   public class EfUserDal: EfEntityRepositoryBase<User,ReCapContext>, IUserDal
    {

    }
}
