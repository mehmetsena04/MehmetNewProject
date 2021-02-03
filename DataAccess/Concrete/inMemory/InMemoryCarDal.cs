using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.inMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ CarBrandId=1,CarId=10,CarDailyPrice=500,CarDescription="ALMAN",CarModelYear=1999,ColorId="Beyaz"},
                new Car{ CarBrandId=2,CarId=20,CarDailyPrice=1500,CarDescription="İTALYAN",CarModelYear=2009,ColorId="Siyah"},
                new Car{ CarBrandId=3,CarId=30,CarDailyPrice=2500,CarDescription="HOLLANDA",CarModelYear=2019,ColorId="Mavi"},
                new Car{ CarBrandId=4,CarId=40,CarDailyPrice=3500,CarDescription="JAPONYA",CarModelYear=2020,ColorId="Gri"},
                new Car{ CarBrandId=5,CarId=50,CarDailyPrice=4500,CarDescription="AMERİKA",CarModelYear=1988,ColorId="Kırmızı"},
                new Car{ CarBrandId=6,CarId=60,CarDailyPrice=5500,CarDescription="TÜRKİYE",CarModelYear=2021,ColorId="Mor"},
                new Car{ CarBrandId=7,CarId=70,CarDailyPrice=6500,CarDescription="GİNE",CarModelYear=1997,ColorId="Beyaz"}
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car cartodelete = null;
            cartodelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(cartodelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllbyCategory(int categoryId)
        {
            return _cars.Where(c => c.CarCategoryId == categoryId).ToList();

        }



        public void GetbyId(Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            //Gönderdiğim ürün ıdsine sahip olan listedeki ürünü bul
            Car cartoUpdate = null;
            cartoUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            cartoUpdate.CarBrandId = car.CarBrandId;
            cartoUpdate.CarDailyPrice = car.CarDailyPrice;
            cartoUpdate.CarDescription = car.CarDescription;
            cartoUpdate.CarId = car.CarId;
            cartoUpdate.CarModelYear = car.CarModelYear;
            cartoUpdate.ColorId = car.ColorId;


        }


    }
}
