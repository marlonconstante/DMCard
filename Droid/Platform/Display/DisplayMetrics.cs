using Android.App;
using Tabloide.Platform.Display;

namespace Tabloide.Droid.Platform.Display
{
	public class DisplayMetrics : IDisplayMetrics
	{
		public ScreenSize GetScreenSize()
		{
			var metrics = Application.Context.Resources.DisplayMetrics;
			var width = metrics.WidthPixels / metrics.Density;
			var height = metrics.HeightPixels / metrics.Density;

			return new ScreenSize(width, height);
		}
	}
}
