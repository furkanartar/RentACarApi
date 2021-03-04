using Business.Constants;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Business
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = FileHelper.AddAsync(file);
            carImage.Date = DateTime.Today;
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            var oldPath = $@"{Environment.CurrentDirectory}\wwwroot{_carImageDal.Get(c => c.Id == carImage.Id).ImagePath}";
            FileHelper.DeleteAsync(oldPath);

            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }
        public IResult Update(IFormFile file, CarImage carImage)
        {
            var oldPath = $@"{Environment.CurrentDirectory}\wwwroot{_carImageDal.Get(c => c.Id == carImage.Id).ImagePath}";
            carImage.ImagePath = FileHelper.UpdateAsync(oldPath, file);

            _carImageDal.Update(carImage);
            return new SuccessResult();
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(p => p.Id == id));
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetAllImagesByCarId(int id)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == id));
        }

        private IResult CheckIfCarOfImageLimitExceeded(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.CarOfImageLimitExceeded);
            }

            return new SuccessResult();
        }

        private IResult CheckIfCarImageIsNullExceeded(int carId)
        {
            var results = _carImageDal.GetAll(c => c.CarId == carId);
            foreach (var result in results)
            {
                if (result.ImagePath == null)
                {
                    return new ErrorResult(Messages.CarImageIsNull);
                }
            }

            return new SuccessResult();
        }
    }
}
