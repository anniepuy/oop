using System;

namespace ooP
{
    public class human
    {
        //member variable
        public string firstName;
        public string lastName;

        //member method
        public void IntroducingMyself()
        {
            Console.WriteLine("hi, I'm {0} {1}", firstName, lastName);
        }
    }
}