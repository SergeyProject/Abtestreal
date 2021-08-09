using System;
using System.Collections.Generic;
using System.Linq;
using Abtestreal.DAL.EF;
using Abtestreal.DAL.Models;
using Abtestreal.DAL.Repository.Interfaces;

namespace Abtestreal.DAL.Repository
{
    public class UserRegRepository : IUserRegRepository
    {

        // Создание пользователя
        public int Create(UserRegDal user)
        {
            using (UserRegContext db = new UserRegContext())
            {
                try
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return user.Id;
                }
                catch(Exception )
                {
                    return -1;
                }
            }
        }

        // Получение пользователя по ID
        public UserRegDal GetUser(int id)
        {
            using (UserRegContext db = new UserRegContext())
            {
                UserRegDal user = db.Users.Find(id);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
        }

        //  Получение списка всех пользователей
        public IEnumerable<UserRegDal> GetAll()
        {
            using (UserRegContext db = new UserRegContext())
                return db.Users.ToList();
        }


        // Удаление пользователя по ID
        public bool Delete(int Id)
        {
            using (UserRegContext db = new UserRegContext())
            {
                UserRegDal user = db.Users.Find(Id);
                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                    return true;
                }
                else return false;
            }
        }
    }
}
