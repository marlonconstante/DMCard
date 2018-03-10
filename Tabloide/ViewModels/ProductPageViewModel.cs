using Prism.Mvvm;
using Prism.Navigation;
using Tabloide.Models;

namespace Tabloide.ViewModels
{
	public class ProductPageViewModel : BindableBase, INavigatedAware
	{
		INavigationService navigationService;

		public Product Item { get; set; }

		public ProductPageViewModel(INavigationService navigationService)
		{
			this.navigationService = navigationService;
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			Item = parameters.GetValue<Product>("Item");
		}
	}
}
