using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ID;
            string Name;
            Char Employee_Gender;
            double Employee_salary;
            DateTime doj;
            Console.WriteLine("Enter the ID");
            ID=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name of employee");
            Name=Console.ReadLine();
            Console.WriteLine("Enter the Employee Gender");
            Employee_Gender=char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employee Salary");
            Employee_salary=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the doj");
            doj=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ID \t Name \t Employee_Gender \t Employee_salary \t doj");
            Console.WriteLine("\n--------------------------------------------------------\n");
            Console.WriteLine(+ID+ "\t"+Name+"\t\t"+Employee_Gender+"\t\t"+Employee_salary+"\t\t"+doj);
            Console.ReadKey();

        }
    }
}
