using Android.Content;
using Tabloide.Controls;
using Tabloide.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AGColor = Android.Graphics.Color;
using ARColor = Android.Resource.Color;

[assembly: ExportRenderer(typeof(CustomListView), typeof(CustomListViewRenderer))]
namespace Tabloide.Droid.Renderers
{
	public class CustomListViewRenderer : ListViewRenderer
	{
		public CustomListViewRenderer(Context context) : base(context)
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
		{
			base.OnElementChanged(e);

			if (Control != null) {
				Control.SetSelector(ARColor.Transparent);
				Control.CacheColorHint = AGColor.Transparent;
			}
		}
	}
}
