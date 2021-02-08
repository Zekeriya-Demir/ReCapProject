using Business.Concrete;
using DataAccsess.Concrete.EntityFreamwork;
using DataAccsess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.DailyPrice);

            }

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var brand in brandManager.GetByBrandId(1))
            //{
            //    Console.WriteLine(brand.BrandName);

            //}

        }
    }
}
