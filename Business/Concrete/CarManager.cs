using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using DataAccess;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;

namespace Business
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public Car GetById(int id)
        {
            return _carDal.Get(Car => Car.CarId == id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(car => car.BrandId == id).ToList();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(car => car.ColorId == id).ToList();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Güzel kardeşim, Açıklama uzunluğu en az 2 karakter günlük fiyat ise en az 1 TL olmalı. Düzeltirsen sevinirim.");
            }
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
    }
}

