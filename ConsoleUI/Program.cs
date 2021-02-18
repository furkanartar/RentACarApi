using System;
using Business;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using Entities;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarCRUD();
            //BrandCRUD();
            //ColorCRUD();
            //GetCarDetails();

            RentalManager _rentalManager = new RentalManager(new RentalDal());

            Console.WriteLine(_rentalManager.Add(new Rental { CarId = 2, CustomerId = 1, RentDate = new DateTime(2021, 01, 01), ReturnDate = new DateTime(2021, 02, 12) }).Message);
        }

        private static void GetCarDetails()
        {
            EfCarDal _efCarDal = new EfCarDal();
            foreach (var car in _efCarDal.GetCarDetails())
            {
                Console.WriteLine($"{car.CarName} {car.ColorName} {car.BrandName} {car.DailyPrice} TL");
            }

            Console.Read();
        }

        private static void ColorCRUD()
        {
            ColorManager _colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("Tüm renklerimiz:");
            foreach (var color in _colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }

            Console.WriteLine("İstediğiniz renk:");
            Console.WriteLine(_colorManager.GetById(1).Data.ColorName);

            Console.WriteLine("renk eklendi.");
            _colorManager.Add(new Color() { ColorName = "Turuncu" });

            Console.WriteLine("renk güncellendi");
            _colorManager.Update(new Color() { Id = 6, ColorName= "Fuşya" });

            Console.WriteLine("renk silindi");
            _colorManager.Delete(new Color() { Id = 6 });
        }

        private static void BrandCRUD()
        {
            BrandManager _brandManager = new BrandManager(new EfBrandDal());

            Console.WriteLine("Tüm markalarımız:");
            foreach (var brand in _brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }

            Console.WriteLine("İstediğiniz marka:");
            Console.WriteLine(_brandManager.GetById(1).Data.BrandName);

            Console.WriteLine("Marka eklendi.");
            _brandManager.Add(new Brand() {BrandName = "Hyundai"});

            Console.WriteLine("Marka güncellendi");
            _brandManager.Update(new Brand() {Id = 5, BrandName = "Aston Martin"});

            Console.WriteLine("Marka silindi");
            _brandManager.Delete(new Brand() {Id = 5});
        }

        private static void CarCRUD()
        {
            CarManager _carManager = new CarManager(new EfCarDal());

            Console.WriteLine("Tüm araçlarımız:");
            foreach (var VARIABLE in _carManager.GetAll().Data)
            {
                Console.WriteLine(VARIABLE.Description);
            }

            Console.WriteLine("\n \n" + "İstediğiniz araç:");
            Console.WriteLine(_carManager.GetById(2).Data.Description);

            Console.WriteLine("Aracınız eklendi.");
            _carManager.Add(new Car() {BrandId = 3, ColorId = 3, DailyPrice = 1, Description = "Fiat Linea", ModelYear = 2012});

            Console.WriteLine("Aracınız güncellendi.");
            _carManager.Update(new Car()
                {BrandId = 1, Id = 21, ColorId = 1, DailyPrice = 199999, Description = "Fiat Egea", ModelYear = 2021});

            Console.WriteLine("Aracınız silindi.");
            _carManager.Delete(new Car() {Id = 21});
        }
    }
}
