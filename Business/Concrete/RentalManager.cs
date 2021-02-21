using System;
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