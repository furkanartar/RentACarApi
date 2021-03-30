using Core.DataAccess.EntityFramework;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    //Bu servis sahtedir. Lütfen bunu unutmayın!
    public class EfPaymentCreditCard : EfEntityRepositoryBase<CreditCard, CarRentalContext>, IPaymentDal
    {
    }
}