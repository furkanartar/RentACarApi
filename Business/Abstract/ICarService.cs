using System.Collections.Generic;
using Entities;

namespace Business
{
    public interface ICarService
    {
        Car GetById(int id);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(int id);
    }
}

//GetById, GetAll, Add, Update, Delete