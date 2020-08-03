using System;

namespace ooP
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of my class
            //instance of the class
           human denis = new human("denis", "Wagner", "brown");
           //access public variable from outside, and even change it.
           //alternative method --denis.firstName = "Denis";
           // alternative method denis.lastName = "Wagner";
           //call methods of the class
           denis.IntroducingMyself();

           human ann = new human("Ann", "Hagan", "Blue");
          // ann.firstName = "Ann";
           //ann.lastName = "Hagan";

           ann.IntroducingMyself();


           Console.ReadKey();
        }
    }
}