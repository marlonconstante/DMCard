using Xamarin.Forms;

namespace Tabloide.Controls
{
	public partial class DividerBar : ContentView
	{
		public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(DividerBar), default(string));

		public string Title {
			get { return (string)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}

		public DividerBar()
		{
			InitializeComponent();
		}
	}
}
