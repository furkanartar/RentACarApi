using System.Collections.Generic;
using Entities;

namespace Business
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int id);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}

