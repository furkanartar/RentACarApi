using Entities;
using System.Collections.Generic;
using Core.DataAccess;
using Entities.DTOs;

namespace DataAccess
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDTO> GetCarDetails();
    }
}
