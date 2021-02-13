using Business.Concrete;
using Core.Utilities;
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
            
            // RentalAddTest();
            // CustomerAddTest();
            // UserGetAllTest();

            // UserDeleteTest();
            // UserUpdateTest();
            // UserAdd();

            // CarAddTest();
            // CarUpdateTest();
            // CarDeleteTest();            
            // CarsByBrandIdTest();
            // CarDetailTest();
            // BrandTest();
            // ColorTest();
            // GetByBrandIdTest();

        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            rentalManager.Add(new Rental { CarId = 2, CustomerId = 1, RentDate = new DateTime(2021, 2, 13), ReturnDate = new DateTime(2021, 2, 20) });
        }

        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { UserId = 1, CompanyName = "Test" });
        }

        private static void UserGetAllTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            if (result.Success == true)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.FirstName);

                }
            }
        }

        private static void UserDeleteTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Delete(new User { Id = 3 });
        }

        private static void UserUpdateTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Update(new User { Id = 2, FirstName = "Hakan", LastName = "Yıldız", Email = "hakan@gm.co" });
        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { FirstName = "Fatih", LastName = "Kale", Email = "fatih@gmail.com", Password = "17124" });
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 2, ColorId = 1, ModelYear = 2017, DailyPrice = 250, Description = "indirimli" });
        }

        private static void CarsByBrandIdTest()
        {
            // marka id ye göre dataları getiriyoruz.
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByBrandId(2);
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDeleteTest()
        {
            // Delete
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { Id = 1007 });
        }

        private static void CarUpdateTest()
        {
            // Update
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { Id = 1007, BrandId = 2, ColorId = 1, ModelYear = 2006, Description = "Kampanya" });
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "-" + car.ColorName + " - " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            // Joinlenen tabloları getiriyoruz.
        }

        //private static void GetByBrandIdTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());

        //    foreach (var brand in brandManager.GetByBrandId(3))
        //    {
        //        Console.WriteLine(brand.BrandName);

        //    }
        //}

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Füme" });
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Toyota" });
            brandManager.Update(new Brand { Id = 3, BrandName = "Toyota Corolla" });
            brandManager.Delete(new Brand { Id = 5 });
            brandManager.Add(new Brand { BrandName = "Nissan" });
        }
    }
}
