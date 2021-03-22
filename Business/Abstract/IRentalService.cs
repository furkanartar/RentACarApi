using System.Collections.Generic;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Entities.Dtos;

namespace Business
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IResult Add(Rental rental);
    }
}