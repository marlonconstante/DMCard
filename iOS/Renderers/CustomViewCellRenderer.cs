using Tabloide.Controls;
using Tabloide.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomViewCell), typeof(CustomViewCellRenderer))]
namespace Tabloide.iOS.Renderers
{
	public class CustomViewCellRenderer : ViewCellRenderer
	{
		public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
		{
			var cell = base.GetCell(item, reusableCell, tv);

			if (cell != null) {
				cell.SelectionStyle = UITableViewCellSelectionStyle.None;
			}

			return cell;
		}
	}
}
