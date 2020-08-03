using System;

namespace ooP
{
    public class human
    {
        //member variable
        public string firstName;
        public string lastName;
        private string eyeColor;

        //constructor
        public human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        //member method
        public void IntroducingMyself()
        {
            Console.WriteLine("hi, I'm {0} {1}", firstName, lastName);
            Console.WriteLine("My eye color is {0}", eyeColor);
        }
    }
}