using System;

namespace Tabloide.Platform.Display
{
	public class ScreenSize
	{
		public double FullWidth { get; set; }

		public double FullHeight { get; set; }

		public double HalfWidth => FullWidth * 0.5d;

		public double HalfHeight => FullHeight * 0.5d;

		public double QuarterWidth => FullWidth * 0.25d;

		public double QuarterHeight => FullHeight * 0.25d;

		public ScreenSize(double width, double height)
		{
			FullWidth = Math.Min(width, height);
			FullHeight = Math.Max(width, height);
		}
	}
}
