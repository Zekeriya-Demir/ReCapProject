using Business.Concrete;
using DataAccsess.Abstract;
using DataAccsess.Concrete.EntityFreamwork;
using DataAccsess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add
            //Car car1 = new Car();

            //car1.BrandId = 2;
            //car1.ColorId = 1;
            //car1.ModelYear = 201;
            //car1.DailyPrice = 275;
            //car1.Description = "Aylık kiralık";




            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(car1);

            // Update
            //CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Update(new Car { Id = 1007,BrandId=2,ColorId=1, ModelYear = 2006, Description = "Kampanya" });

            // Delete
            // CarManager carManager = new CarManager(new EfCarDal());
            // carManager.Delete(new Car { Id = 1007 });

            // marka id ye göre dataları getiriyoruz.
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.DailyPrice);
            }

            // Joinlenen tabloları getiriyoruz.
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + "-"+ car.ColorName +" - "+car.DailyPrice);
            }

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandName = "Toyota" });
            //brandManager.Update(new Brand { Id=3, BrandName = "Toyota Corolla" });
            // brandManager.Delete(new Brand { Id = 5 });
            // brandManager.Add(new Brand {BrandName = "Nissan" });

            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorName = "Füme" });

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var brand in brandManager.GetByBrandId(1))
            //{
            //    Console.WriteLine(brand.BrandName);

            //}



        }
    }
}
