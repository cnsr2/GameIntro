using System;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { BirthYear = 2001, FirstName = "Emre Can", Id = 1, IdentityNumber = "12345", LastName = "Sarı" };
            UserManager userManager = new UserManager(new UserValidateManager());
            userManager.Add(user);
            GameManager gameManager = new GameManager();
            gameManager.Sell(user);
            OfferManager offerManager = new OfferManager();
            Offer offer1 = new Offer() { Id = 1, OldPrice = 200, NewPrice = 125 };
            offerManager.Add(offer1);
            offerManager.Delete(offer1);
            offerManager.Update(offer1);
        }
    }
}
