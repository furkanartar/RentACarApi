using System.Collections.Generic;
using Core.Utilities.Results;
using Entities;

namespace Business
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IResult Add(Rental rental);
    }
}