using Abtestreal.BLL.Services;
using Abtestreal.DAL.Models;
using Abtestreal.Service.Models;

namespace Abtestreal.WebApp.Mappers
{
    public static class UserMapper
    {
        public static UserService ToUserRegService(this  UserRegDal userService)
        {
            return new UserService
            {
                Id = userService.Id,
                LastActivityDate = userService.LastActivityDate,
                RegistrationDate = userService.RegistrationDate,
                UserId = userService.UserId
            };


        }
    }
}
