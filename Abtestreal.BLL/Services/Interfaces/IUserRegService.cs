using Abtestreal.BLL.Models;
using System.Collections.Generic;
using System.Collections;

namespace Abtestreal.BLL.Services.Interfaces
{
   public interface IUserRegService
    {
        int Create(UserRegBLL user);
        UserRegBLL GetUser(int id);
        //IEnumerable<UserRegBLL> GetAll();
        IEnumerable GetAll();
        bool Delete(int Id);
    }
}
