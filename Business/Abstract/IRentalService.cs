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
        IResult Update(Rental rental);
        IDataResult<List<Rental>> GetAllByCarId(int carId);
        IDataResult<List<Rental>> GetPaymentMethodNotAddedByCarId(int carId);
    }
}