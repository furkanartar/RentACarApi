using System.Collections.Generic;
using Core.Entities.Concrete;

namespace Core.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}