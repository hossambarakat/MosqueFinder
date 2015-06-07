using Autofac;
using MosqueFinder.Forms.Services.Abstarcts;
using MosqueFinder.iOS.Services;

namespace MosqueFinder.iOS.Core.Autofac
{
    public class IosModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LocationService>().As<ILocationService>();
            builder.RegisterType<MapService>().As<IMapService>();
        }
    }
}