using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_abstract
{
    public class Dog : Animal //inherits the methods from Animal abstract
    {
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat!");
        }
    }
}
