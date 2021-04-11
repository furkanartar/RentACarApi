using System.Collections.Generic;
using Core.Utilities.Results;
using Entities;

namespace Business
{
    public interface IFindeksService
    {
        IDataResult<Findeks> GetById(int id);

        IDataResult<Findeks> GetByCustomerId(int customerId);

        IDataResult<List<Findeks>> GetAll();

        IResult Add(Findeks findeks);

        IResult Update(Findeks findeks);

        IResult Delete(Findeks findeks);

        IDataResult<Findeks> CalculateFindeksScore(Findeks findeks);
    }
}