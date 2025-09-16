using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESCARTIN_InheritancewithUserInput
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//  Name: Jencky Descartin
			//Section: IT301
			// Exer Name: Inheritance with User Input


			//Promt the user to choose what kind of jeans
			Console.WriteLine("Choose your Jeans:    ");
			Console.WriteLine("1 - Slim Jeans");
			Console.WriteLine("2 - Flared Jeans");
			Console.Write("Enter only the number: ");

			// Read user input and convert to integer\
			int choice = Convert.ToInt32(Console.ReadLine());

			//if the user choooss SlimJEans
			if (choice == 1)
			{
				//Promt for slim jeans color
				Console.Write("Enter color:   ");
				string color = Console.ReadLine();

				//Promt for the slim jeans size]
				Console.Write("Enter Size:   ");
				string size = Console.ReadLine();

				//Create a Slimjeans object with the provided details
				SlimJeans slimjeans = new SlimJeans("Lev's","slimjeans", color ,size);
				
				//Clear the console screen 
				Console.Clear();

				//Display Slimjeans Details
				Console.WriteLine("Slimjeans Details");
				Console.WriteLine();

				//Call method to Dispaly Slimjeans deatils
				slimjeans.DisplayInfo();
				slimjeans.DisplayColorSlimJeans();
			}
			//If the user chooses FlaredJeans
			else if(choice == 2)
			{
				// Prompt for flaredjeans type
				Console.Write("Enter type of jeans");
				string type = Console.ReadLine();

				//Prompt for price of the flaredjeans
				Console.Write("Enter price");
				int price =Convert.ToInt32(Console.ReadLine());

				//Create a Flaredjeans object with the provided details
				FlaredJeans flaredJeans1 = new FlaredJeans("Flare fit", "Flaredjeans", price,type); 

				//Clear the console screen
				Console.Clear();

				//Display Flaredjeans detials
				Console.WriteLine("Flaredjeans Details");
				Console.WriteLine();
				 
				//Call method to display flaredjeans
				flaredJeans1.DisplayInfo();
			}
			// If the user enters an invalid choice  
			else
			{
				// Clear the console and display error message
				Console.Clear();
				Console.WriteLine("Invalid choice");
		    }

			// Wait for user to press a key before closing
			Console.ReadKey();



		}
	}
}
