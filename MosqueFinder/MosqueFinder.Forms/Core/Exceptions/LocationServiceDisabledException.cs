using System;

namespace MosqueFinder.Forms.Core.Exceptions
{
    public class LocationServiceDisabledException : Exception
    {
        public LocationServiceDisabledException()
        {
        }

        public LocationServiceDisabledException(string message)
            : base(message)
        {

        }
    }
}