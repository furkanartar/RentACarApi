using Business.Constants;
using Core.Utilities.Results;
using Entities;

namespace Business
{
    public class CarImageManager:ICarImageService
    {
        private ICarImageService _carImageManager;

        public CarImageManager(ICarImageService carImageManager)
        {
            _carImageManager = carImageManager;
        }


        public IResult Add(CarImage carImage)
        {
            _carImageManager.Add(carImage);
            return new SuccessResult(Messages.Added);
        }
    }
}