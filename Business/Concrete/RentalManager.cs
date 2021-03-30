using System;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Business;
using Entities.Dtos;

namespace Business
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.Listed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<List<Rental>> GetAllByCarId(int carId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll().Where(car=>car.CarId == carId).ToList(), Messages.Listed);
        }

        public IDataResult<List<Rental>> GetPaymentMethodNotAddedByCarId(int carId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll().Where(car => car.CarId == carId && car.Enable == false).ToList(), Messages.Listed);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(), Messages.Listed);
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            IResult result = BusinessRules.Run(CheckIfCurrentCarIsRent(rental));

            if (result != null)
            {
                return result;
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.Added);
        }

        private IResult CheckIfCurrentCarIsRent(Rental rental)
        {
            var rents = _rentalDal.GetAll(rent => rent.CarId == rental.CarId && rent.ReturnDate >= rental.RentDate); 
            if (rents.Count != 0)
            {
                return new ErrorResult(Messages.TheCarIsAlreadyRented);
            }

            return new SuccessResult(Messages.Added);
        }
    }
}