using System.Threading.Tasks;
using MosqueFinder.Forms.Features.MosquesAroundMe;
using MosqueFinder.Forms.Services;
using MosqueFinder.Forms.Services.Abstarcts;

namespace MosqueFinder.iOS.Services
{
    class LocationService : ILocationService
    {
        public Task<Location> GetCurrentLocation()
        {
            return Task.Factory.StartNew(() => new Location(23, 23));
        }
    }
}