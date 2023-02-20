using System;
namespace aqza.Models
{
	public class ProductItems
	{
		public int Id { get; set; }
		public List<ProductItem> ProductItem { get; set; } = null!;

    }
}

