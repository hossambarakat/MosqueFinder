using MosqueFinder.Forms.Features.MosquesAroundMe;

namespace MosqueFinder.Forms.Core.Domain
{
    public class Mosque
    {
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