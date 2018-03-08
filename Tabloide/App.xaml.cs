using Prism;
using Prism.Ioc;
using Prism.Unity;
using Tabloide.Configurations;
using Tabloide.Services.Showcase;
using Tabloide.ViewModels;
using Tabloide.Views;
using Xamarin.Forms;

namespace Tabloide
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer)
		{
		}

		protected override void OnInitialized()
		{
			InitializeComponent();
			AppConfig.AddSettings(Resources);

			NavigationService.NavigateAsync("NavigationPage/HomePage");
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.Register<IShowcaseService, ShowcaseService>();

			containerRegistry.RegisterForNavigation<NavigationPage>();
			containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
			containerRegistry.RegisterForNavigation<ProductPage, ProductPageViewModel>();
		}
	}
}
