using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion objLion = new Lion("LMAO", 420);
            Tiger objTiger = new Tiger("KEKW", 69);
            objLion.Show();
            objTiger.Show();
            Console.ReadKey();
        }
    }
}
