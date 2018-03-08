using Xamarin.Forms;

namespace Tabloide.Behaviors
{
	public class NoSelectionListViewBehavior : Behavior<ListView>
	{
		protected override void OnAttachedTo(ListView bindable)
		{
			base.OnAttachedTo(bindable);

			bindable.ItemSelected += OnItemSelected;
		}

		protected override void OnDetachingFrom(ListView bindable)
		{
			base.OnDetachingFrom(bindable);

			bindable.ItemSelected -= OnItemSelected;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			(sender as ListView).SelectedItem = null;
		}
	}
}
