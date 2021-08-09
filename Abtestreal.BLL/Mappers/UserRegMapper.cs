using Abtestreal.BLL.Models;
using Abtestreal.DAL.Models;

namespace Abtestreal.BLL.Mappers
{
   public static class UserRegMapper
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

        public static UserRegBLL ToUserRegDal(this UserRegDal userRegDal)
        {
            return new UserRegBLL
            {
                Id = userRegDal.Id,
                LastActivityDate = userRegDal.LastActivityDate,
                RegistrationDate = userRegDal.RegistrationDate,
                UserId = userRegDal.UserId
            };
        }
    }
}
