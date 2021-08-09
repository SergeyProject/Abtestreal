using Abtestreal.Service.Models;
using System.Collections;
using System.Collections.Generic;

namespace Abtestreal.Service.Abstract.Interfaces
{
   public interface IApplicationService
    {
        void Create(UserService user);
        IEnumerable GetAll();
    }
}
