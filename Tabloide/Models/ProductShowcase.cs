using System.Collections.Generic;

namespace Tabloide.Models
{
	public class ProductShowcase : List<Product>
	{
		public string Category { get; }

		public ProductShowcase(string category)
		{
			Category = category;
		}
	}
}
