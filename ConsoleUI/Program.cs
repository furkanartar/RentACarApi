using System;
using Business;
using DataAccess.Concrete.EntityFramework;
using Entities;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager _carManager = new CarManager(new EfCarDal());

            _carManager.Add(new Car() { BrandId = 1, ColorId = 3, DailyPrice = 50,  Description = "Fiat Linea", ModelYear = 1999 });
        }
    }
}
