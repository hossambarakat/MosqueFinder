using MosqueFinder.Forms.Core.Domain;

namespace MosqueFinder.Forms.Services.Abstarcts
{
    public interface IMapService
    {
        void OpenMaps(Location source, Location destination);
    }
}
