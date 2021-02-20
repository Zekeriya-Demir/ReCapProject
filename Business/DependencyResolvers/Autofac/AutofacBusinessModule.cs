using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
   public class AutofacBusinessModule:Module
    {
        // Interface'lerin tuttuğu referansları belirtiyoruz.
        // Örnek: IcarService istenilirse CarManager örneği ver. SingleInstance -> tek bir örnek tut.
        // Uygulama ayağa kalktığında "Load" çalışacak.
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();
        }
    }
}
