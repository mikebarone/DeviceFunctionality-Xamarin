using System;
using System.Collections.Generic;

namespace DeviceFunctionality
{
	public class MenuService
	{
		private List<MenuItem> _menuItems;

		public MenuService()
		{
			_menuItems = new List<MenuItem>
			{
				new MenuItem { Id = 1, Label = "Device", Description = "Info about the device"},
				new MenuItem { Id = 2, Label = "GPS", Description = "Current location"},
				new MenuItem { Id = 3, Label = "Battery", Description = "Battery status"}
			};
		}

		public List<MenuItem> getMenu()
		{
			return _menuItems;
		}
	}
}
