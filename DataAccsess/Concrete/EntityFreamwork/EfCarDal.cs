using Core.EntitiyFreamework;
using DataAccsess.Abstract;
using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTOs;
using System.Text;

namespace DataAccsess.Concrete.EntityFreamwork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext contex = new ReCapContext())
            {
                var result = from c in contex.Cars
                             join b in contex.Brands on c.BrandId equals b.Id
                             join cl in contex.Colors on c.ColorId equals cl.Id
                             select new CarDetailDto {CarId = c.Id, DailyPrice=c.DailyPrice, BrandName = b.BrandName, ColorName=cl.ColorName };

                return result.ToList();

            }
        }
    }
}
