using Core.DataAccess.EntityFramework;
using Entities;
using System.Collections.Generic;
using System.Linq;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars on rental.CarId equals car.Id
                             join brand in context.Brands on car.Id equals brand.Id

                             join customer in context.Customers on rental.CustomerId equals customer.Id
                             join user in context.Users on customer.UserId equals user.Id

                             select new RentalDetailDto()
                             {
                                 BrandName = brand.BrandName,
                                 FullName = $"{user.FirstName} {user.LastName}"
                             };
                return result.ToList();
            }
        }
    }
}