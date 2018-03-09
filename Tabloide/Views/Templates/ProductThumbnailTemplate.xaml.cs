using System.Windows.Input;
using Xamarin.Forms;

namespace Tabloide.Views.Templates
{
	public partial class ProductThumbnailTemplate : ContentView
	{
		public static readonly BindableProperty TapCommandProperty = BindableProperty.Create(nameof(TapCommand), typeof(ICommand), typeof(ProductThumbnailTemplate), default(ICommand));

		public ICommand TapCommand {
			get { return (ICommand)GetValue(TapCommandProperty); }
			set { SetValue(TapCommandProperty, value); }
		}

		public ProductThumbnailTemplate()
		{
			InitializeComponent();
		}
	}
}
