namespace MosqueFinder.Forms.Core.Domain
{
    public class Location
    {
        private readonly double _latitude;
        private readonly double _longitude;

        public Location(double latitude, double longitude)
        {
            _latitude = latitude;
            _longitude = longitude;
        }

        public double Latitude
        {
            get { return _latitude; }
        }

        public double Longitude
        {
            get { return _longitude; }
        }
    }
}