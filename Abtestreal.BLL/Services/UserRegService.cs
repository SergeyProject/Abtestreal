using System;
using Abtestreal.BLL.Services.Interfaces;
using System.Collections.Generic;
using Abtestreal.BLL.Models;
using Abtestreal.DAL.Repository.Interfaces;
using Abtestreal.BLL.Mappers;
using System.Collections;

namespace Abtestreal.BLL.Services
{
    public class UserRegService : IUserRegService
    {
        IUserRegRepository _userRegRepository;

        public UserRegService(IUserRegRepository userRegRepository)
        {
            _userRegRepository = userRegRepository;
        }
        public int Create(UserRegBLL user)
        {
            return _userRegRepository.Create(user.ToUserRegService());
        }

        public bool Delete(int Id)
        {
            return _userRegRepository.Delete(Id);
        }

        //public IEnumerable<UserRegBLL> GetAll()
        //{
        //    return (IEnumerable<UserRegBLL>)_userRegRepository.GetAll();
        //}

        public UserRegBLL GetUser(int id)
        {
            return _userRegRepository.GetUser(id).ToUserRegDal();
        }

        public IEnumerable GetAll()
        {
            return _userRegRepository.GetAll();
        }
    }
}
