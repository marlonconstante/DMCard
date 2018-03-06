using Foundation;
using Tabloide.Configurations;
using Tabloide.iOS.Platform.Display;
using UIKit;
using Xamarin.FileStorage.iOS;

namespace Tabloide.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			AppConfig.SetUp(new FileStorage(), new DisplayMetrics());

			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
