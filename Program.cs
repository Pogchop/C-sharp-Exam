using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder test = new Cylinder();
            Console.WriteLine("Enter the dimension of the cylinder");
            Console.WriteLine("Radius: ");
            test.radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            test.height = Convert.ToDouble(Console.ReadLine());
            test.Process();
            test.Result();
            Console.ReadKey();
        }
    }
}
