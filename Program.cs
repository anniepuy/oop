using System;

namespace ooP
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of my class
            //instance of the class
           human denis = new human();
           //access public variable from outside, and even change it.
           denis.firstName = "Denis";
           denis.lastName = "Wagner";
           //call methods of the class
           denis.IntroducingMyself();

           human ann = new human();
           ann.firstName = "Ann";
           ann.lastName = "Hagan";

           ann.IntroducingMyself();
           

           Console.ReadKey();
        }
    }
}