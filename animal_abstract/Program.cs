using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_abstract
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("ABSTRACT CLASSES - PART ONE ");


            //new dog object
            Dog Dog = new Dog();

            //name of dog
            Console.WriteLine("\n\nEnter your dogs name: ");
            string dogName = Convert.ToString(Console.ReadLine());
            Dog.SetName(dogName);
            Console.WriteLine($"\nHello, {dogName}!");

            //colour of dog
            Console.WriteLine("\nWhat is the colour of your dog? ");
            string dogColour = Console.ReadLine();
            Dog.SetColour(dogColour);

            //age of dog
            Console.WriteLine("How old is your dog? ");
            int dogAge = Convert.ToInt32(Console.ReadLine());
            Dog.SetAge(dogAge);

            //call Eat method for dog
            Dog.Eat();


            //new cat object
            Cat Cat = new Cat();

            //name of cat
            Console.WriteLine("\nEnter your cats name: ");
            string catName = Console.ReadLine();
            Cat.SetName(catName);
            Console.WriteLine($"\nHello, {catName}!");


            //colour of cat
            Console.WriteLine("\nWhat is the colour for your cat: ");
            string catColour = Console.ReadLine();
            Cat.SetColour(catColour);


            //age of cat
            Console.WriteLine("How old is your cat? ");
            int catAge = Convert.ToInt32(Console.ReadLine());
            Cat.SetAge(catAge);

            //call Eat method for cat
            Cat.Eat();


            Console.ReadLine();
        }


    }

}

