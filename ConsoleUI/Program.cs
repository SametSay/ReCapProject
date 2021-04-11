using Business.Concrete;
using Business.Constants;
using Core.Entities.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //    BrandManager brandManager = new BrandManager(new EfBrandDal());
            //    foreach (var brand in brandManager.GetAll())
            //    {
            //        Console.WriteLine(brand.BrandName);
            //    }
            //}
        }
        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 2, CustomerId = 1, RentDate = DateTime.Now });
            Console.WriteLine(result.Message);
        }

        private static void UserTest()
        {
            //UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new User
            //{FirstName = "Ali", LastName = "Aksu", Email = "alaks@hotmail.com", Password = "12564"
            //});
            //Console.WriteLine(Messages.UserAdded);

            //private static void CarTest()
            //{
            //    CarManager carManager = new CarManager(new EfCarDal());

            //     var result = carManager.GetCarDetails();

            //    if (result.Success)
            //    {
            //        foreach (var car in result.Data)
            //        {
            //            Console.WriteLine(car.Id + "/" + car.BrandName);
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine(result.Message);
            //    }
            //    foreach (var car in carManager.GetCarDetails().Data)
            //    {
             //       Console.WriteLine(car.Id + "/" + car.BrandName);
                    // Console.WriteLine(car.Description + "\nArabanın Günlük Kirası: " + car.DailyPrice);
            //    }

            //Car car1 = carManager.GetbyId(1);
            //Console.WriteLine("\n\nId'si 1 olan Otomobilin Kirası: " + car1.DailyPrice);
            //Console.WriteLine("Id'si 1 olan Tesla Model X'in günlük kirası 600 olarak güncellendi. \n");
            //car1.DailyPrice = 600;
            //carManager.Update(car1);

            //Car car6 = carManager.GetbyId(6);
            //Console.WriteLine("Id'si 6 olan Porsche Cayonne listeden silindi.\n");
            //carManager.Delete(car6);

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description + "\nArabanın Günlük Kirası: " + car.DailyPrice);
            //}
        }
    }
}
