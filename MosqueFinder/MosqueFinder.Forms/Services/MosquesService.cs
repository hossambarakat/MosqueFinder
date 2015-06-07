using System.Collections.Generic;
using System.Threading.Tasks;
using MosqueFinder.Forms.Core.Domain;
using MosqueFinder.Forms.Features.MosquesAroundMe;
using MosqueFinder.Forms.Services.Abstarcts;

namespace MosqueFinder.Forms.Services
{
    public class MosquesService : IMosquesService
    {
        public Task<List<Mosque>> MosquesAroundMe(Location location)
        {
            var mosques = new List<Mosque>
            {
                new Mosque
                {
                    Name = "Parramatta Mosque",
                    Address1 = "150 Marsden Street",
                    Address2 = "North Parramatta 2150",
                    Jumma = true,
                    LadiesRoom = true,
                    Weekdays = "Fajr, Duhr, Asr, Maghreb, Issa",
                    Saturady = "Fajr, Duhr, Asr, Maghreb, Issa",
                    Sunday = "Fajr, Duhr, Asr, Maghreb, Issa",
                    Verified = true,
                },
                new Mosque
                {
                    Name = "Parramatta Mosque",
                    Address1 = "150 Marsden Street",
                    Address2 = "North Parramatta 2150",
                    Jumma = true,
                    LadiesRoom = false,
                    Weekdays = "Duhr, Asr, Issa",
                    Saturady = "Fajr, Duhr, Asr",
                    Sunday = "Fajr, Duhr, Asr, Maghreb, Issa",
                    Verified = false,
                }
            };

            return Task.Factory.StartNew(() => mosques);
        }
    }
}
