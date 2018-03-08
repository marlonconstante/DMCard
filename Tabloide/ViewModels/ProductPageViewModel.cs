using Prism.Mvvm;
using Prism.Navigation;

namespace Tabloide.ViewModels
{
	public class ProductPageViewModel : BindableBase, INavigatedAware
	{
		INavigationService navigationService;

		public ProductPageViewModel(INavigationService navigationService)
		{
			this.navigationService = navigationService;
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}
