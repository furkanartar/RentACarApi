using System;
using Business;
using Entities;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager _carManager = new CarManager();

            Console.WriteLine(_carManager.GetById(2).Description);

            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine();

            _carManager.Add(new Car() { CarId = 4, BradId = 4, ColorId = 4, ModelYear = 2021, Description = "add metodu", DailyPrice = 699999 });
            foreach (var car in _carManager.GetAll())
            {
                Console.WriteLine(car.BradId);
            }

            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine();

            _carManager.Update(new Car() { CarId = 1, BradId = 9, ColorId = 9, ModelYear = 2021, Description = "Güncellenen kasa", DailyPrice = 1499999999 });
            foreach (var car in _carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine();

            _carManager.Delete(3);
            foreach (var car in _carManager.GetAll())
            {
                Console.WriteLine(car.BradId);
            }
        }
    }
}
