using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CoreLocation;
using MosqueFinder.Forms.Core.Domain;
using MosqueFinder.Forms.Core.Exceptions;
using MosqueFinder.Forms.Features.MosquesAroundMe;
using MosqueFinder.Forms.Services;
using MosqueFinder.Forms.Services.Abstarcts;
using UIKit;

namespace MosqueFinder.iOS.Services
{
    class LocationService : ILocationService
    {
        private readonly CLLocationManager _locationManager;
        private Location _location;

        public LocationService()
        {
            _locationManager = new CLLocationManager();
            Init();
        }

        private void Init()
        {
            if (!CLLocationManager.LocationServicesEnabled)
                throw new LocationServiceDisabledException("Location service disabled");

            _locationManager.DesiredAccuracy = CLLocation.AccuracyBest;

            if (UIDevice.CurrentDevice.CheckSystemVersion(6, 0))
            {
                _locationManager.LocationsUpdated += (sender, e) => { UpdateLocation(e.Locations[e.Locations.Length - 1]); };
            }
            else
            {
                // this won't be called on iOS 6 (deprecated)
                _locationManager.UpdatedLocation += (sender, e) => { UpdateLocation(e.NewLocation); };
            }

            _locationManager.StartUpdatingLocation();
        }

        private void UpdateLocation(CLLocation newLocation)
        {
            _location = new Location(newLocation.Coordinate.Latitude, newLocation.Coordinate.Longitude);
        }

        public async Task<Location> GetCurrentLocation()
        {
            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            cancellationToken.CancelAfter(TimeSpan.FromSeconds(10));
            var token = cancellationToken.Token;
           
            await Task.Run(() =>
            {
                while (_location == null)
                {
                    token.ThrowIfCancellationRequested();
                }
            }, token);

            return await Task.Run(() => _location, token);
        }
    }
}