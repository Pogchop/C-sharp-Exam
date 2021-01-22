using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Cylinder
    {
        public double radius;
        public double height;
        public double BaseArea;
        public double LateralArea;
        public double TotalArea;
        public double Volume;
        public void Process()
        {
            BaseArea = radius * radius * Math.PI;
            LateralArea = 2 * Math.PI * radius * height;
            TotalArea = 2 * Math.PI * radius * (height + radius);
            Volume = Math.PI * radius * radius * height;
        }
        public void Result()
        {
            Console.WriteLine("Cylinder Characteristic");
            Console.WriteLine("Radius {0}, Height{1}", radius, height);
            Console.WriteLine("Base {0}, Lateral {1}, Total {2}, Volume{3}", BaseArea, LateralArea, TotalArea, Volume);

        }
    }
}
