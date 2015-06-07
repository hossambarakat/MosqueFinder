using System.Dynamic;
using MosqueFinder.Forms.Core.Domain;
using System.Windows.Input;
using MosqueFinder.Forms.Services.Abstarcts;
using Xamarin.Forms;

namespace MosqueFinder.Forms.Features.MosquesAroundMe
{
    public class MosqueViewModel
    {

        public MosqueViewModel(IMapService mapService, ILocationService locationService)
        {
            ViewMapCommand = new Command(async () =>
            {
                mapService.OpenMaps(Location, await locationService.GetCurrentLocation());
            });
        }

        public ICommand ViewMapCommand { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Weekdays { get; set; }
        public string Saturady { get; set; }
        public string Sunday { get; set; }
        public bool Jumma { get; set; }
        public bool LadiesRoom { get; set; }
        public Location Location { get; set; }
        public bool Verified { get; set; }

    }
}