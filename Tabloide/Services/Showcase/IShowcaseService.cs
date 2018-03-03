using System.Collections.Generic;
using Tabloide.Models;

namespace Tabloide.Services.Showcase
{
	public interface IShowcaseService
	{
		IList<ProductShowcase> GetPersonalProductRecommendations();
	}
}
