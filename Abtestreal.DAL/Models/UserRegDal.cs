using System;

namespace Abtestreal.DAL.Models
{
   public class UserRegDal
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastActivityDate { get; set; }
    }
}
