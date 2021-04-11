using Core.DataAccess.EntityFramework;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFindeksDal : EfEntityRepositoryBase<Findeks, CarRentalContext>, IFindeksDal
    {
    }
}