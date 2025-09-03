using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace Descartin_SimpleInheritance
{
    internal class Program
    //Name: Jencky Descartin
    //Section: IT301
    //EXER6: Simple Inheritance with Properties
    {
        static void Main(string[] args)
        {
            RegularStudent regular = new RegularStudent
            {
                Name = "Jencky Descartin",
                Program = "BSIT",
                Section = "IT301A"
            };
            Console.WriteLine("Regular Stdent Info:");
            regular.BasicInfo(); // Inherited Method
            regular.SectionEnrolled(); // Regular Student Specific Method

            Console.WriteLine();
            IrregularStuddent irregular = new IrregularStuddent
            {
                Name = "Savana Mariano",
                Program = "BEED",
                UnitsEnrolled = "20"

            };
            Console.WriteLine("Irregular Student Info:");
            irregular.BasicInfo(); // Inherited Method
            irregular.UnitsSemEnrolled(); // Irregular Student Specific Method

           
            Console.ReadKey();


        }

        
    }
}
