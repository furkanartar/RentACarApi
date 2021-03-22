using Entities;
using System.Collections.Generic;
using Core.DataAccess;
using Entities.Dtos;

namespace DataAccess
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetAllCarDetails();
    }
}
