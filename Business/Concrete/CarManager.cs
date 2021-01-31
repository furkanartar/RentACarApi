using System.Collections.Generic;
using DataAccess.Concrete;
using Entities;

namespace Business
{
    public class CarManager : ICarService
    {
        CarDal _carDal = new CarDal();
        public List<Car> GetById(int id)
        {
            return _carDal.GetById(id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(int id)
        {
            _carDal.Delete(id);
        }
    }
}

