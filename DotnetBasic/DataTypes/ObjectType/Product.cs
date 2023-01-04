using System;
namespace DataTypes.ObjectType
{
	public class Product
	{
		public String Name { get; set; }
		public Double Price { get; set; }
		public String Category { get; set; }

		public Product(String name, Double price, String category)
		{
			this.Name = name;
			this.Price = price;
			this.Category = category;
		}
	}
}

