using System.Collections.ObjectModel;
using MosqueFinder.Forms.Services.Abstarcts;

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
            var mosques = await _mosquesServcie.MosquesAroundMe(await _locationService.GetCurrentLocation());
            foreach (var mosque in mosques)
            {
                Mosques.Add(new MosqueViewModel()
                {
                    Address1 = mosque.Address1,
                    Address2 = mosque.Address2,
                    Saturady = mosque.Saturady,
                    Sunday = mosque.Sunday,
                    Jumma = mosque.Jumma,
                    LadiesRoom = mosque.LadiesRoom,
                    Name = mosque.Name,
                    Location = mosque.Location,
                    Verified = mosque.Verified,
                    Weekdays = mosque.Weekdays
                });
            }
        }
    }
}
