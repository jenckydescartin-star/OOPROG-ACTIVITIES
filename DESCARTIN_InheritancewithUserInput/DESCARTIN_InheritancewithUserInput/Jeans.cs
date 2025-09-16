using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESCARTIN_InheritancewithUserInput
{
	class Jeans
	{
		public string brand;
		public string model;

		//Constructor for class method
		public Jeans(string brand, string model)
		{
			Console.WriteLine("Brand: " + brand);
			Console.WriteLine("Model: " + model);
		}
		//Base class method
		public void DisplayInfo()
		{
			Console.WriteLine("Brand: " + brand);
			Console.WriteLine("Model: " + model);
		}
	}
	class SlimJeans : Jeans //Derived Class
	{
		//Fields
		public string color;
		public string size;

		//Constructor for slimjeans
		public SlimJeans(string brand, string model, string color, string size) : base(brand, model)
		{
			this.color = color;
			this.size = size;
		}
		//Method for slimjeans Derived Class
		public void DisplayColorSlimJeans()
		{
			Console.WriteLine("Color: " + color);
			Console.WriteLine("Size: " + size);
		}
	}
	class FlaredJeans : Jeans //Another one Derived Class
	{
		//Fields
		public string type;
		public int price;

		//Constructor for FlaredJeans Derived Class
		public FlaredJeans(string brand, string model, int price, string type) : base(brand, model)
		{
			this.type = type;
			this.price = price;
		}
		// Method for flaredjeans Derived Class
		public void DisplayFlaredJeans()
		{
			Console.WriteLine("Type: " + type);
			Console.WriteLine("Price; " + price);
		}

	}
}

