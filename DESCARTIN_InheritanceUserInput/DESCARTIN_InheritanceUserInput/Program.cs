using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESCARTIN_InheritanceUserInput
{
    internal class Program
    {

        //Jencky Descartin
        //Section: IT301
        //Exercise Title: Inheritance with User Input
        //Main Method - Entry point of the program
        static void Main(string[] args)
        {
            //Jeans User Input
            Console.WriteLine("Choose a type of Jeans: ");
            Console.WriteLine("- SlimJeans ");
            Console.WriteLine("- FlaredJeans ");
            Console.Write("Enter your type: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            //If the user chooses SlimJeans
            if (choice == 1)
            {
                //User for slimjeans brand
                Console.Write("Enter the Brand : ");
                string brand = Console.ReadLine();

                //User for slimjeans model
                Console.Write("Enter the model ");
                string model = Console.ReadLine();

                //User for jeans color
                Console.Write("Enter your jeans size: ");
                string color = Console.ReadLine();

                //User for jeans size
                Console.Write("Enter the size(Small, Medium, Large: ");
                string size = Console.ReadLine();
                
                SlimJeans slimjeans = new SlimJeans(model, color, brand, size);

                //Clear the console screen 
                Console.Clear();

            }
            //If the user Chooses FlaredJeans
            else if (choice == 2)
            {
                //User for flaredjeans type
                Console.Write("Enter the color: ");
                string color = Console.ReadLine();

                //User for flaredjeans price
                Console.Write("Enter the price: ");
                string size = Console.ReadLine();



                //Clear the console screen
                Console.Clear();
            }
            // If thw user enters an invalid choice
            else
            {
                //Clear the console and display error message
                Console.Clear();
                Console.WriteLine("Invalid Choices");
            }
            
            //Wait for user to press a key before closing
            Console.ReadKey();

        }
    }
}
