using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class CarDal : ICarDal
    {
        private List<Car> _cars;
        public CarDal()
        {
            _cars = new List<Car>()
            {
                new Car() {CarId = 1, BradId = 1, ColorId = 1, ModelYear = 2020, Description = "1 numaralı kayıt", DailyPrice = 1499999999},
                new Car() {CarId = 2, BradId = 2, ColorId = 2, ModelYear = 2020, Description = "2 numaralı kayıt", DailyPrice = 1299999999},
                new Car() {CarId = 3, BradId = 3, ColorId = 3, ModelYear = 2020, Description = "3 numaralı kayıt", DailyPrice = 999999999}
            };
        }

        public Car GetById(int id)
        {
            return _cars.FirstOrDefault(p => p.CarId == id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine(car.Description + " Açıklamalı kayıt eklendi.");
            }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BradId = carToUpdate.BradId;
            carToUpdate.ColorId = carToUpdate.ColorId;
            carToUpdate.ModelYear = carToUpdate.ModelYear;
            carToUpdate.Description = carToUpdate.Description;
            carToUpdate.DailyPrice = carToUpdate.DailyPrice;
            Console.WriteLine(carToUpdate.Description + " Açıklamalı kayıt güncellendi.");
        }

        public void Delete(int id)
        {
            Car car = _cars.SingleOrDefault(p => p.CarId == id);
            _cars.Remove(car);
            Console.WriteLine(id + " Id'li kayıt silindi.");
        }
    }
}