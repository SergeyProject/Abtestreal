using System;

namespace Abtestreal.BLL.Models
{
   public class UserRegBLL
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastActivityDate { get; set; }
    }
}
