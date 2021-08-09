using Abtestreal.DAL.Models;
using System.Collections.Generic;

namespace Abtestreal.DAL.Repository.Interfaces
{
    public interface IUserRegRepository
    {
        int Create(UserRegDal user);
        UserRegDal GetUser(int id);
        IEnumerable<UserRegDal> GetAll();
        bool Delete(int Id);
    }
}
