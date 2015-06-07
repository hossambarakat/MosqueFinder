using System.Threading.Tasks;
using MosqueFinder.Forms.Core.Domain;
using MosqueFinder.Forms.Features.MosquesAroundMe;

namespace MosqueFinder.Forms.Services.Abstarcts
{
    public interface ILocationService
    {
        Task<Location> GetCurrentLocation();
    }
}
