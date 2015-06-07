using System.Collections.ObjectModel;
using System.Diagnostics;
using MosqueFinder.Forms.Core.DI;
using MosqueFinder.Forms.Core.Domain;
using MosqueFinder.Forms.Services.Abstarcts;
using Xamarin.Forms;

namespace MosqueFinder.Forms.Features.MosquesAroundMe
{
    public class MosquesListViewModel
    {
        private readonly IMosquesService _mosquesServcie;
        private readonly ILocationService _locationService;

        public ObservableCollection<MosqueViewModel> Mosques { get; private set; }


        public MosquesListViewModel(IMosquesService mosquesServcie, ILocationService locationService)
        {
            _mosquesServcie = mosquesServcie;
            _locationService = locationService;
            Mosques = new ObservableCollection<MosqueViewModel>();

        }

        public async void Load()
        {
            Mosques.Clear();
            var location = await _locationService.GetCurrentLocation();

            //await App.RootPage.DisplayAlert("Alert", string.Format("latitude: {0}, longitutde: {1}", location.Latitude, location.Longitude), "Ok");

            var mosques = await _mosquesServcie.MosquesAroundMe(location);

            foreach (var mosque in mosques)
            {
                var mosqueViewModel = IoCHelper.Resolve<MosqueViewModel>();
                mosqueViewModel.Address1 = mosque.Address1;
                mosqueViewModel.Address2 = mosque.Address2;
                mosqueViewModel.Saturady = mosque.Saturady;
                mosqueViewModel.Sunday = mosque.Sunday;
                mosqueViewModel.Jumma = mosque.Jumma;
                mosqueViewModel.LadiesRoom = mosque.LadiesRoom;
                mosqueViewModel.Name = mosque.Name;
                mosqueViewModel.Location = mosque.Location;
                mosqueViewModel.Verified = mosque.Verified;
                mosqueViewModel.Weekdays = mosque.Weekdays;
                Mosques.Add(mosqueViewModel);
            }
        }
    }
}