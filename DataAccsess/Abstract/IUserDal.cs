using Core.DataAccsess;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Abstract
{
   public interface IUserDal: IEntityRepository<User>
    {
    }
}
