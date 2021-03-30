using Core.Utilities.Results;
using Entities;
using System.Collections.Generic;

namespace Business
{
    public interface IPaymentService
    {
        IDataResult<List<CreditCard>> GetAll();
        IDataResult<List<CreditCard>> GetById(int id);
        IResult Add(CreditCard creditCard);
        IResult Update(CreditCard creditCard);
        IResult Delete(CreditCard creditCard);
    }
}