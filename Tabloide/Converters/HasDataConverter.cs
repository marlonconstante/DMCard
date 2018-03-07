using System;
using System.Collections;
using System.Globalization;
using Xamarin.Forms;

namespace Tabloide.Converters
{
	public class HasDataConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is string) {
				return !string.IsNullOrWhiteSpace(value as string);
			}

			if (value is ICollection) {
				return (value as ICollection).Count > 0;
			}

			return value != null;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
