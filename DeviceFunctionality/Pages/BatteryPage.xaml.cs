using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DeviceFunctionality
{
	public partial class BatteryPage : ContentPage
	{
		private BatteryService _batteryService;

		public BatteryPage(MenuItem menuItem)
		{
			InitializeComponent();
			Title = menuItem.Label;

			_batteryService = new BatteryService();

			BindingContext = _batteryService.GetStatus();
		}
	}
}
