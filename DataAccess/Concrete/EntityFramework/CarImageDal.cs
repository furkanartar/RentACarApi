using Core.DataAccess.EntityFramework;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarImageDal:EfEntityRepositoryBase<CarImage, CarRentalContext>, ICarImageDal
    {
        
    }
}