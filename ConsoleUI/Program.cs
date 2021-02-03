using Businness.Concrete;
using DataAccess.Concrete.inMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarBrandId);
                Console.WriteLine(car.CarCategoryId);
                Console.WriteLine(car.CarDailyPrice);
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.CarModelYear); 
                Console.WriteLine(car.CarId);
                Console.WriteLine(car.CarDescription);
                Console.WriteLine("---------------------------------");

            }
        }
    }
}
