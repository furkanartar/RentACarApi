using System;
using System.Collections.Generic;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess;
using Entities;

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

        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate < DateTime.Today)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.Added);
            }

            return new ErrorResult(Messages.RentInvalid);
        }
    }
}