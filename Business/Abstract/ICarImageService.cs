using System.Collections.Generic;
using Core.Utilities.Results;
using Entities;
using Microsoft.AspNetCore.Http;

namespace Business
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetImageById(int id);
        IDataResult<List<CarImage>> GetImagesByCarId(int id);
        IResult Add(IFormFile file, CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);
    }
}