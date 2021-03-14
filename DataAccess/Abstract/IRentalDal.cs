using System.Collections.Generic;
using Core.DataAccess;
using Core.Utilities.Results;
using Entities;
using Entities.DTOs;

namespace DataAccess
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        public List<RentalDetailDto> GetRentalDetails();
    }
}