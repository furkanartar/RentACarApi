using Core.DataAccess.EntityFramework;
using Entities;
using Entities.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetAllCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands on car.BrandId equals brand.Id
                             join color in context.Colors on car.ColorId equals color.Id

                             select new CarDetailDto()
                             {
                                 CarId = car.Id,
                                 BrandId = brand.Id,
                                 ColorId = color.Id,
                                 ModelYear = car.ModelYear,
                                 CarName = car.CarName,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 CarImages = (from ImagePath in context.CarImages
                                     where ImagePath.CarId == car.Id
                                     select new CarImage
                                     {
                                         Id = ImagePath.Id,
                                         CarId = ImagePath.CarId,
                                         ImagePath = ImagePath.ImagePath,
                                         Date = ImagePath.Date
                                     }).ToList()
                             };
                return result.ToList();
            }
        }
    }
}