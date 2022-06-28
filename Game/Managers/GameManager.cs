using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GameManager : IGameServices
    {
        public void Sell(User user)
        {
            Console.WriteLine("Satın alma işlemi başarılı.");
            Console.WriteLine("{0} adlı Oyuncu oyunu satın aldı.",user.FirstName+" "+user.LastName);
        }
    }
}
