using System.Collections.Generic;
using System.Reflection;
using Core.Utilities.Results;
using Entities;

namespace Business
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(int customerId);
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
    }
}