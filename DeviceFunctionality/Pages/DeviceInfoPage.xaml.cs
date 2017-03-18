using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DeviceFunctionality
{
	public partial class DeviceInfoPage : ContentPage
	{
		private DeviceInfoService _deviceInfoService;

		public DeviceInfoPage(MenuItem menuItem)
		{
			InitializeComponent();
			Title = menuItem.Label;

			_deviceInfoService = new DeviceInfoService();

			BindingContext = _deviceInfoService.GetInfo();
		}
	}
}
