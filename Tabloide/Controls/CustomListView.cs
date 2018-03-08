using Tabloide.Behaviors;
using Xamarin.Forms;

namespace Tabloide.Controls
{
	public class CustomListView : ListView
	{
		public CustomListView()
		{
			Behaviors.Add(new NoSelectionListViewBehavior());
		}
	}
}
