using System;

namespace ooP
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of my class
            //instance of the class
           human denis = new human("denis", "Wagner", "brown", 30);
           //access public variable from outside, and even change it.
           //alternative method --denis.firstName = "Denis";
           // alternative method denis.lastName = "Wagner";
           //call methods of the class
           denis.IntroducingMyself();

           human ann = new human("Ann", "Hagan", "Blue", 42);
          // ann.firstName = "Ann";
           //ann.lastName = "Hagan";

            human billy = new human("Bill", "Hagan", "Blue", 49);
            human naomi = new human("Naomi", "Abell", "Hazel", 0);
            human bingo = new human("Bingo");


           ann.IntroducingMyself();
           billy.IntroducingMyself();
           naomi.IntroducingMyself();
           bingo.IntroducingMyself();
        


            human basicHuman = new human();
            basicHuman.IntroducingMyself();

           Console.ReadKey();
        }
    }
}