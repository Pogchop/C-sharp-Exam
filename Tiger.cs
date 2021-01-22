using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Tiger : Animal
    {
        public Tiger(string name, int weight)
        {
            base.setMe(name, weight);
        }
        public override void Show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Weight: " + weight);
        }
    }
}
