using Abtestreal.BLL.Models;
using Abtestreal.Service.Models;

namespace Abtestreal.Service.Mappers
{
   public static class UserMapper
    {
        public static UserRegBLL ToUserRegBLL(this UserService userService)
        {
            return new UserRegBLL
            {
                Id = userService.Id,
                LastActivityDate = userService.LastActivityDate,
                RegistrationDate = userService.RegistrationDate,
                UserId = userService.UserId
            };
        }
    }
}
