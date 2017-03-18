using System;
using Plugin.Battery;

namespace DeviceFunctionality
{
	public class BatteryService
	{

		public BatteryModel GetStatus()
		{
			var battery = CrossBattery.Current;

			return new BatteryModel
			{
				Power = battery.PowerSource.ToString(),
				Level = battery.RemainingChargePercent.ToString(),
				Status = battery.Status.ToString()
			};
		}
	}
}
