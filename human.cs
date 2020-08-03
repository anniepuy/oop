using System;

namespace ooP
{
    public class human
    {
        //member variable
        public string firstName;
        public string lastName;
        private string eyeColor;

        private int age;

        //default constuctor
        public human() {
            Console.WriteLine("Constructor called. Object created");

        }

        public human(string firstName)
        {
            this.firstName = firstName;
            
        }
       public human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //paremeterized constructor
        public human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        //member method
        public void IntroducingMyself()
        {
            if(age != 0 && lastName != null && eyeColor != null && firstName != null) {
                Console.WriteLine("hi, I'm {0} {1}.", firstName, lastName);
                Console.WriteLine("My eye color is {0} and I am {1}  years old.", eyeColor, age);
            }
            else  if(age != 0 && lastName != null && firstName != null)
            {
                Console.WriteLine("hi, I'm {0} {1}", firstName, lastName);
            }
            else if (age != 0 && firstName != null)
            {
                Console.WriteLine("hi I am {0} and I am {1} years old.", firstName, age);
            }
            else if (firstName != null)
            {
                 Console.WriteLine("hi I am {0}.", firstName);
            }
        }
    }
}
