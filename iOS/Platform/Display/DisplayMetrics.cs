using Tabloide.Platform.Display;
using UIKit;

namespace Tabloide.iOS.Platform.Display
{
	public class DisplayMetrics : IDisplayMetrics
	{
		public ScreenSize GetScreenSize()
		{
			var bounds = UIScreen.MainScreen.Bounds;

			return new ScreenSize(bounds.Width, bounds.Height);
		}
	}
}
