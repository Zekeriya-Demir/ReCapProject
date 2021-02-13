using Core.EntitiyFreamework;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Concrete.EntityFreamwork
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,ReCapContext>, IRentalDal
    {
    }
}
