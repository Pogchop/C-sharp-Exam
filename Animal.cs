using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    abstract class Animal
    {
        public string name;
        public int weight;
        public void setMe (string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }
        public abstract void Show();

    }
}
