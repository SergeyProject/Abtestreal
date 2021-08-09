using Abtestreal.BLL.Services.Interfaces;
using Abtestreal.Service.Abstract.Interfaces;
using Abtestreal.Service.Models;
using Abtestreal.Service.Mappers;
using System.Collections.Generic;
using System.Collections;

namespace Abtestreal.Service.Abstract
{
    public class ApplicationService : IApplicationService
    {
        IUserRegService _userRegService;
        public ApplicationService(IUserRegService userRegService)
        {
            _userRegService = userRegService;
        }
        public void Create(UserService user)
        {
            _userRegService.Create(user.ToUserRegBLL());
        }

        public IEnumerable GetAll()
        {
            return _userRegService.GetAll();
        }
      
    }
}
