using Descartin_SimpleInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descartin_SimpleInheritance
{
     class Student
    
    {

        public string Name { get; set; }
        public string Program { get; set; }

        public void BasicInfo() // Method to Display the info of the student
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Program: {Program}");
        }

    }
}

class RegularStudent : Student // Derived class
{
    public string Section { get; set; }

    public void SectionEnrolled() // Method Specific to Irregular class
    {
        Console.WriteLine($"Section: {Section}");
    }
}

class IrregularStuddent : Student
{
    public string UnitsEnrolled { get; set; }

    public void UnitsSemEnrolled()
    {
        Console.WriteLine($"Units Enrolled this Semester: {UnitsEnrolled}");
    }




}

