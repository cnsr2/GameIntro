using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class OfferManager : IOfferService
    {
        public void Add(Offer offer)
        {
            Console.WriteLine("{0} Id li Kampanya Hesabınıza Eklenmiştir.",offer.Id);
        }

        public void Delete(Offer offer)
        {
            Console.WriteLine("{0} Id li Kampanya Kapsamındaki Süreniz Dolmuştur.",offer.Id);
            Console.WriteLine("Kampanyalar Silindi.");
        }

        public void Update(Offer offer)
        {
            Console.WriteLine("{0} Id li Eski Fiyatı {1} Tl olan oyun şuanda size özel kampanyayla {2} Tl bu fırsatı kaçırma !!",offer.Id, offer.OldPrice,offer.NewPrice);
            Console.WriteLine("Marketinizi Kontrol Etmeyi Unutmayınız.");
        }
    }
}
