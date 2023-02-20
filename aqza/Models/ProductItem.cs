using System;
namespace aqza.Models
{
	public class ProductItem
	{
		public int Id { get; set; }
		public Product Product { get; set; } = null!;
		public double TotalPrice { get; set; }

	}
}

