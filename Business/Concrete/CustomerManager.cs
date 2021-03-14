using Business.Constants;
using Core.Utilities.Results;
using DataAccess;
using Entities;
using System.Collections.Generic;

namespace Business
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }


        public IDataResult<List<Customer>> GetAll()
        {

            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.Listed);

        }

        public IDataResult<Customer> GetById(int customerId)
        {
            var result = _customerDal.Get(customer => customer.Id == customerId);
            return new SuccessDataResult<Customer>(result, Messages.Listed);
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.Deleted);
        }
    }
}