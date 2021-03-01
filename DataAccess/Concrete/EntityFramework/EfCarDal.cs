using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entities;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDTO> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from car in context.Cars
                    join brand in context.Brands on car.BrandId equals brand.Id
                    join color in context.Colors on car.ColorId equals color.Id

                    select new CarDetailDTO()
                        {  CarName = car.CarName, ColorName = color.ColorName, BrandName = brand.BrandName, DailyPrice = Convert.ToDouble(car.DailyPrice) };
                return result.ToList();
            }
        }
    }
}