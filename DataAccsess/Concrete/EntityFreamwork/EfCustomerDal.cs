using Core.EntitiyFreamework;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Concrete.EntityFreamwork
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer, ReCapContext> ,ICustomerDal
    {
    }
}
