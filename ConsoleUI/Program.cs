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
            //CarCRUD();
            //BrandCRUD();
            //ColorCRUD();

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
            foreach (var color in _colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }

            Console.WriteLine("İstediğiniz renk:");
            Console.WriteLine(_colorManager.GetById(1).ColorName);

            Console.WriteLine("renk eklendi.");
            _colorManager.Add(new Color() { ColorName = "Turuncu" });

            Console.WriteLine("renk güncellendi");
            _colorManager.Update(new Color() { ColorId = 6, ColorName= "Fuşya" });

            Console.WriteLine("renk silindi");
            _colorManager.Delete(new Color() { ColorId = 6 });
        }

        private static void BrandCRUD()
        {
            BrandManager _brandManager = new BrandManager(new EfBrandDal());

            Console.WriteLine("Tüm markalarımız:");
            foreach (var brand in _brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }

            Console.WriteLine("İstediğiniz marka:");
            Console.WriteLine(_brandManager.GetById(1).BrandName);

            Console.WriteLine("Marka eklendi.");
            _brandManager.Add(new Brand() {BrandName = "Hyundai"});

            Console.WriteLine("Marka güncellendi");
            _brandManager.Update(new Brand() {BrandId = 5, BrandName = "Aston Martin"});

            Console.WriteLine("Marka silindi");
            _brandManager.Delete(new Brand() {BrandId = 5});
        }

        private static void CarCRUD()
        {
            CarManager _carManager = new CarManager(new EfCarDal());

            Console.WriteLine("Tüm araçlarımız:");
            foreach (var VARIABLE in _carManager.GetAll())
            {
                Console.WriteLine(VARIABLE.Description);
            }

            Console.WriteLine("\n \n" + "İstediğiniz araç:");
            Console.WriteLine(_carManager.GetById(2).Description);

            Console.WriteLine("Aracınız eklendi.");
            _carManager.Add(new Car() {BrandId = 3, ColorId = 3, DailyPrice = 1, Description = "Fiat Linea", ModelYear = 2012});

            Console.WriteLine("Aracınız güncellendi.");
            _carManager.Update(new Car()
                {BrandId = 1, CarId = 21, ColorId = 1, DailyPrice = 199999, Description = "Fiat Egea", ModelYear = 2021});

            Console.WriteLine("Aracınız silindi.");
            _carManager.Delete(new Car() {CarId = 21});
        }
    }
}
