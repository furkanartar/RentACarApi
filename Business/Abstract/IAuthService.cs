using Core.Entities.Concrete;
using Core.Security.Jwt;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}