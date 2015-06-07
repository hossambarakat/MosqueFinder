using System.Dynamic;

namespace MosqueFinder.Forms.Features.MosquesAroundMe
{
    public class MosqueViewModel
    {
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Weekday { get; set; }
        public string Saturady { get; set; }
        public string Sunday { get; set; }
        public string Jumma { get; set; }
        public bool LaddiesRoom { get; set; }

        public Location Location { get; set; }

    }

    public class Location
    {
        private readonly long _latitude;
        private readonly long _longitude;

        public Location(long latitude, long longitude)
        {
            _latitude = latitude;
            _longitude = longitude;
        }

        public long Latitude
        {
            get { return _latitude; }
        }

        public long Longitude
        {
            get { return _longitude; }
        }
    }
}