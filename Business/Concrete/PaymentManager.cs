using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;

namespace Business
{
    public class PaymentManager : IPaymentService
    {
        private IPaymentDal _paymentDal;

        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CreditCard>>(_paymentDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<CreditCard>> GetById(int id)
        {
            return new SuccessDataResult<List<CreditCard>>(_paymentDal.GetAll(cc => cc.Id == id), Messages.Listed);
        }

        public IResult Add(CreditCard creditCard)
        {
            _paymentDal.Add(creditCard);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(CreditCard creditCard)
        {
            _paymentDal.Update(creditCard);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(CreditCard creditCard)
        {
            _paymentDal.Delete(creditCard);
            return new SuccessResult(Messages.Deleted);
        }
    }
}