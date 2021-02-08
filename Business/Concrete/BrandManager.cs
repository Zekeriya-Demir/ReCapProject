using Business.Abstract;
using DataAccsess.Concrete.EntityFreamwork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        EfBrandDal _brand;

        public BrandManager(EfBrandDal brand)
        {
            _brand = brand;
        }

        public List<Brand> GetAll()
        {
            return _brand.GetAll();
        }

        public List<Brand> GetByBrandId(int id)
        {
            return _brand.GetAll(b=>b.Id == id).ToList();
        }
    }
}
