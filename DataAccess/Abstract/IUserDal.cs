using Core.DataAccess;
using Entities;

namespace DataAccess
{
    public interface IUserDal : IEntityRepository<User>
    {
        
    }
}