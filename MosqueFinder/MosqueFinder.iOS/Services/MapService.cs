using Foundation;
using MosqueFinder.Forms.Features.MosquesAroundMe;
using MosqueFinder.Forms.Services.Abstarcts;
using UIKit;

namespace MosqueFinder.iOS.Services
{
    public class MapService : IMapService
    {
        private const string AppleBaseMapsUrl = "http://maps.apple.com/";
        private const string SourceAddressParameter = "saddr";
        private const string DestinationAddressParameter = "daddr";

        public void OpenMaps(Location source,Location destination)
        {
            string mapsUrl = string.Format("{0}?{1}={2},{3}&{4}={5},{6}", AppleBaseMapsUrl, SourceAddressParameter,
                source.Latitude, source.Longitude, DestinationAddressParameter, destination.Latitude,
                destination.Longitude);

            if (!UIApplication.SharedApplication.CanOpenUrl(new NSUrl(mapsUrl)))
            {
                var uiAlertView = new UIAlertView
                {
                    Message = "Cannot Open Maps",
                    Title = "Error"
                };
                uiAlertView.Show();
            }

            UIApplication.SharedApplication.OpenUrl(new NSUrl(mapsUrl));
        }
    }
}