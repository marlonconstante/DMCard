using System.Linq;
using System.Windows.Input;
using MvvmHelpers;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Tabloide.Models;
using Tabloide.Services.Showcase;

namespace Tabloide.ViewModels
{
	public class HomePageViewModel : BindableBase, INavigatedAware
	{
		INavigationService navigationService;
		IShowcaseService showcaseService;

		public ObservableRangeCollection<PairedProductShowcase> Showcases { get; }

		public ICommand NavigateProductPageCommand { get; }

		public HomePageViewModel(INavigationService navigationService, IShowcaseService showcaseService)
		{
			this.navigationService = navigationService;
			this.showcaseService = showcaseService;

			Showcases = new ObservableRangeCollection<PairedProductShowcase>();
			NavigateProductPageCommand = new DelegateCommand<Product>(NavigateProductPage);
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			LoadProductsInShowcases();
		}

		void LoadProductsInShowcases()
		{
			var recommendations = showcaseService.GetPersonalProductRecommendations();
			Showcases.ReplaceRange(recommendations.Select(showcase => new PairedProductShowcase(showcase)));
		}

		void NavigateProductPage(Product item)
		{
			navigationService.NavigateAsync("ProductPage", new NavigationParameters {
				{ "Item", item }
			});
		}
	}
}
