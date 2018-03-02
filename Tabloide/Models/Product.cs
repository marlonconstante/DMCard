using System;

namespace Tabloide.Models
{
	public class Product
	{
		public long Code { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public double NormalPrice { get; set; }

		public double PromotionPrice { get; set; }

		public double CardPrice { get; set; }

		public string ImageSource { get; set; }

		public DateTimeOffset ExpirationDate { get; set; }
	}
}
