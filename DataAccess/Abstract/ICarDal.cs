using Entities;
using System.Collections.Generic;

namespace DataAccess
{
    public interface ICarDal
    {
        List<Car> GetById(int id);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(int id);
    }
}
//GetById, GetAll, Add, Update, Delete