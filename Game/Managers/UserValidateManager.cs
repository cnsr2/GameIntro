using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidateManager : IUserValidateService
    {
        public bool Validate(User user)
        {
            if (user.Id == 1 && user.IdentityNumber == "12345" && user.FirstName == "Emre Can" &&
                user.LastName == "Sarı" && user.BirthYear == 2001)
            {
                return true;
            }
            else
            {
               return false;
            }
        }
    }
}
