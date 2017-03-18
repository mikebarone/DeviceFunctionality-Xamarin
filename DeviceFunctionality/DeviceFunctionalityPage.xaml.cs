using Plugin.Connectivity;
using Xamarin.Forms;

namespace DeviceFunctionality
{
	public partial class DeviceFunctionalityPage : ContentPage
	{
		public MenuService menuService;

		public DeviceFunctionalityPage()
		{
			InitializeComponent();
			menuService = new MenuService();

			menuList.ItemsSource = menuService.getMenu();

			//test();
		}

		public void test()
		{
			var testMe = CrossConnectivity.Current;
			Title = testMe.IsConnected.ToString();


		}

		async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;
			var menuItem = e.SelectedItem as MenuItem;

			switch (menuItem.Id)
			{
				case 1:
					await Navigation.PushAsync(new DeviceInfoPage(menuItem));
					break;
				case 2:
					await Navigation.PushAsync(new GPSPage(menuItem));
					break;
				case 3:
					await Navigation.PushAsync(new BatteryPage(menuItem));
					break;
				default:

					break;
			}
			menuList.SelectedItem = null;
		}
	}
}
