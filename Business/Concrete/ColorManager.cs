﻿using Business.Abstract;
using DataAccsess.Abstract;
using DataAccsess.Concrete.EntityFreamwork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        EfColorDal _colorDal;

        public ColorManager(EfColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        
        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            throw new NotImplementedException();
        }

        public Color GetByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}