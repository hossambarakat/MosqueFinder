using MosqueFinder.Forms.Features.MosquesAroundMe;

namespace MosqueFinder.Forms.Services.Abstarcts
{
    public interface IMapService
    {
        void OpenMaps(Location source, Location destination);
    }
}
