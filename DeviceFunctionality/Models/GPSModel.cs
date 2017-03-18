using System;
namespace DeviceFunctionality
{
	public class GPSModel
	{
		public string Time { get; set; }
		public double Altitude { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public double Speed { get; set; }
		public double Heading { get; set; }
		public double Accurancy { get; set; }
		public double AltitudeAccurancy { get; set; }
	}
}
