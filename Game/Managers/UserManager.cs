using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserManager : IUserService
    {
        IUserValidateService _userValidateService1;
        public UserManager(IUserValidateService userValidateService)
        {
            _userValidateService1 = userValidateService;
        }
        public void Add(User user)
        {
            if (_userValidateService1.Validate(user)==true)
            { 
                Console.WriteLine("Doğrulama Başarılı.");
                Console.WriteLine("Kayıt Olundu.");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız.");
                Console.WriteLine("Kayıt Başarısız.");
            }
            
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(User user)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
