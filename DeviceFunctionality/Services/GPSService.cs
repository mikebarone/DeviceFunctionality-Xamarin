using System;
using System.Threading.Tasks;
using Plugin.Geolocator;

namespace DeviceFunctionality
{
	public class GPSService
	{
		async public Task<GPSModel> GetPosition()
		{
			var locator = CrossGeolocator.Current;
			locator.DesiredAccuracy = 50;

			var position = await locator.GetPositionAsync(10000);

			return new GPSModel
			{
				Time = position.Timestamp.ToString(),
				Altitude = position.Altitude,
				Latitude = position.Latitude,
				Longitude = position.Longitude,
				Speed = position.Speed,
				Accurancy = position.Accuracy,
				AltitudeAccurancy = position.AltitudeAccuracy
			};
		}
	}
}
