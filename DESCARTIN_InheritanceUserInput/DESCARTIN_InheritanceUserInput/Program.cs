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
            Console.WriteLine("Enter your type");

            int choice = Convert.ToInt32(Console.ReadLine());

            //If the user chooses Slimbag
            if (choice == 0) 
            {
                //User for slimjeans brand
                Console.Write("Enter Brand : ");
                string brand = Console.ReadLine();

                //User for slimjeans model
                Console.Write();
                string model = Console.ReadLine();

                //User for jeans size
                Console.WriteLine("Enter your jeans size: ");

            }
        }
    }
}
