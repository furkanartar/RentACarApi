using Business.Constants;
using Core.Utilities.Results;
using DataAccess;
using Entities;
using System.IO;

namespace Business
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }


        public IResult Add(CarImage carImage)
        {
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.Added);
        }

        //private IResult CheckIfAddedCarImage(string sourceFilePath, string destinationFilePath)
        //{

        //    return new SuccessResult();
        //}
    }
}
//Resimler projeniz içerisinde bir klasörde tutulacaktır. Resimler yüklendiği isimle değil, kendi vereceğiniz GUID ile dosyalanacaktır.