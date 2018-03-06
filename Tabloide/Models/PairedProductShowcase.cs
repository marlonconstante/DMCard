using System;
using System.Collections.Generic;
using MvvmHelpers;

namespace Tabloide.Models
{
	public class PairedProductShowcase : Grouping<string, Tuple<Product, Product>>
	{
		public PairedProductShowcase(ProductShowcase showcase) : base(showcase.Category, GetPairedProducts(showcase))
		{
		}

		static IEnumerable<Tuple<Product, Product>> GetPairedProducts(ProductShowcase showcase)
		{
			using (var iterator = showcase.GetEnumerator()) {
				while (iterator.MoveNext()) {
					var first = iterator.Current;
					var second = iterator.MoveNext() ? iterator.Current : default(Product);

					yield return Tuple.Create(first, second);
				}
			}
		}
	}
}
