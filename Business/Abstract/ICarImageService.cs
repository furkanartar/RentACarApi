using Core.Utilities.Results;
using Entities;

namespace Business
{
    public interface ICarImageService
    {
        IResult Add(CarImage carImage);
    }
}