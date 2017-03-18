using System;
using Plugin.DeviceInfo;

namespace DeviceFunctionality
{
	public class DeviceInfoService
	{
		public DeviceInfoModel GetInfo()
		{
			var deviceInfo = CrossDeviceInfo.Current;

			return new DeviceInfoModel
			{
				Id = deviceInfo.Id,
				Idiom = deviceInfo.Idiom.ToString(),
				Model = deviceInfo.Model,
				Platform = deviceInfo.Platform.ToString(),
				Version = deviceInfo.Version,
				VersionNumber = deviceInfo.VersionNumber.ToString()
			};
		}
	}
}
