using System;
using System.Collections.Generic;
using Plugin.Geolocator;
using Xamarin.Forms;

namespace DeviceFunctionality
{
	public partial class GPSPage : ContentPage
	{
		private GPSService _gpsService;

		public GPSPage(MenuItem menuItem)
		{
			InitializeComponent();
			Title = menuItem.Label;

			_gpsService = new GPSService();

			getPosition();
		}

		async void getPosition()
		{
			BindingContext = await _gpsService.GetPosition();
		}
	}
}
