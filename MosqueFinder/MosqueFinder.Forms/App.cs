using MosqueFinder.Forms.Core.DI;
using MosqueFinder.Forms.Features.MosquesAroundMe;
using Xamarin.Forms;

namespace MosqueFinder.Forms
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = RootPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
           
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private static NavigationPage _rootPage;

        public static NavigationPage RootPage
        {
            get { return _rootPage ?? (_rootPage = new NavigationPage(new MosquesList())); }
        }
    }
}
