using System.Collections.Generic;
using Core.DataAccess;
using Core.Utilities.Results;
using Entities;
using Entities.Dtos;

namespace DataAccess
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        public List<RentalDetailDto> GetRentalDetails();
    }
}