using Core.Utilities.Results;
using Entities;

namespace Business
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
    }
}