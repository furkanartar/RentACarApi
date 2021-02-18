using Core.DataAccess.EntityFramework;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class UserDal : EfEntityRepositoryBase<User, CarRentalContext>, IUserDal
    {

    }
}