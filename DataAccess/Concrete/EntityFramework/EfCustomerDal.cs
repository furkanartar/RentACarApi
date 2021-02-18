using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer, CarRentalContext>, ICustomerDal
    {
        
    }
}