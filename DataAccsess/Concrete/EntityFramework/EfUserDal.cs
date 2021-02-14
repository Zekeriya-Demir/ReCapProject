using Core.DataAccess.EntityFramework;
using Core.Utilities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfUserDal: EfEntityRepositoryBase<User,ReCapContext>, IUserDal
    {

    }
}
