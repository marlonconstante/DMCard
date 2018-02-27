using Prism.Mvvm;
using Prism.Navigation;
using Tabloide.Services.Showcase;

namespace Tabloide.ViewModels
{
	public class HomePageViewModel : BindableBase, INavigatedAware
	{
		INavigationService navigationService;
		IShowcaseService showcaseService;

		public HomePageViewModel(INavigationService navigationService, IShowcaseService showcaseService)
		{
			this.navigationService = navigationService;
			this.showcaseService = showcaseService;
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}
