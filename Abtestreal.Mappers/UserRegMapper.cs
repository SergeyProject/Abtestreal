using Abtestreal.BLL.Models;
using Abtestreal.DAL.Models;

namespace Abtestreal.Mappers
{
  public static  class UserRegMapper
    {
        public static UserRegDal ToUserRegService(this UserRegBLL userRegBLL)
        {
            return new UserRegDal
            {
                Id = userRegBLL.Id,
                LastActivityDate = userRegBLL.LastActivityDate,
                RegistrationDate = userRegBLL.RegistrationDate,
                UserId = userRegBLL.UserId
            };
        }
    }
}
