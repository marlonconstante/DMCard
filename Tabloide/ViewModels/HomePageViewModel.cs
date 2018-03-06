using System.Linq;
using MvvmHelpers;
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

		public HomePageViewModel(INavigationService navigationService, IShowcaseService showcaseService)
		{
			this.navigationService = navigationService;
			this.showcaseService = showcaseService;

			Showcases = new ObservableRangeCollection<PairedProductShowcase>();
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
	}
}
