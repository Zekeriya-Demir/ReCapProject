﻿using Core.EntitiyFreamework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.EntityFreamwork
{
    public class EfColorDal : EfEntityRepositoryBase<Color, ReCapContext>, IColorDal
    {

    }
}