using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Amanda";
            string lName = "Jonson";
            byte age = 27;
            char gender = 'f';
            long personalID = 8306112507;
            int employeeNum = 27563571;

            Console.WriteLine("First name: {0}", fName);
            Console.WriteLine("Last name: {0}", lName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: " + personalID);
            Console.WriteLine("Unique Employee number: " + employeeNum);
        }
    }
}
