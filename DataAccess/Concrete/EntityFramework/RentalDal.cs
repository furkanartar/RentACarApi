using Core.DataAccess.EntityFramework;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentalDal:EfEntityRepositoryBase<Rental, CarRentalContext>,IRentalDal
    {
        
    }
}