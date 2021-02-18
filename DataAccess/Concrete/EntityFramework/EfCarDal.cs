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
//CarName, BrandName, ColorName, DailyPrice
/*
*select CarName, BrandName, ColorName, DailyPrice from Cars
inner join Brands on Cars.BrandId = Brands.BrandId
inner join Colors on cars.ColorId = Colors.ColorId

*
*
 *using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                    join c in context.Categories 
                    on p.CategoryId equals c.CategoryId
                    select new ProductDetailDTO
                    {ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitsInStock = p.UnitsInStock};
                return result.ToList();
            }
 *
 */