using Autofac;

namespace MosqueFinder.Forms.Core.DI
{
    public static class IoCHelper
    {
        private static IContainer _container;

        public static void Init(params Module[] modules)
        {
            var containerBuilder = new ContainerBuilder();
            foreach (var module in modules)
            {
                containerBuilder.RegisterModule(module);
            }

            _container = containerBuilder.Build();
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}