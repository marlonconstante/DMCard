using Prism;
using Prism.Ioc;
using Prism.Unity;
using Tabloide.Services.Showcase;
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
			NavigationService.NavigateAsync("NavigationPage/MainPage");
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.Register<IShowcaseService, ShowcaseService>();

			containerRegistry.RegisterForNavigation<NavigationPage>();
			containerRegistry.RegisterForNavigation<MainPage>();
		}
	}
}
