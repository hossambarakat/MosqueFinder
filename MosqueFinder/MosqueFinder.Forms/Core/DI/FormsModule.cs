using Autofac;
using MosqueFinder.Forms.Features.MosquesAroundMe;
using MosqueFinder.Forms.Services;
using MosqueFinder.Forms.Services.Abstarcts;

namespace MosqueFinder.Forms.Core.DI
{
    public class FormsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MosquesService>().As<IMosquesService>();
            builder.RegisterType<MosquesListViewModel>().AsSelf();
            builder.RegisterType<MosqueViewModel>().AsSelf();
        }
    }
}
