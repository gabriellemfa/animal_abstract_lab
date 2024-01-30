using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_abstract
{
    //Abstract method for Animal
    public abstract class Animal
    {
        //Constructor:
        private string Name;
        private string Colour;
        private int Age;

        public void SetName(string name)
        {
            this.Name = name;
            //using "this. to simplify name
        }
        public string GetName()
        {
            return this.Name;
        }

        public void SetColour(string colour)
        {
            Colour = colour;
        }
        public string GetColour() 
        {
            return Colour;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public int GetAge()
        {
            return Age;
        }

        //Eat method:
        public abstract void Eat();

    }

}
