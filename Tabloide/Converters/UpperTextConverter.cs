using System;
using System.Globalization;
using Xamarin.Forms;

namespace Tabloide.Converters
{
	public class UpperTextConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value?.ToString().ToUpper(culture);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
