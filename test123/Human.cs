using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test123
{
    public class Human
    {
        private string firstName;
        private string lastName;
        private int age;
        private int energy;

        public int Age { get => age; set => age = value; }
        public string FirstName { set => firstName = value; }
        public string LastName { set => lastName = value; }
        public string FullName { get => firstName + " " + lastName; }
        public string Country { get; set; }
        public Guid Id { get; }

        public Human()
        {
            Id = Guid.NewGuid();
            energy = 4;
        }

        public Human(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            Age = age;
        }

        public Human(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Walk(int step)
        {
            for (int i = 0; i < step; i++)
            {                
                Console.WriteLine("топ-топ");

                if (!CheckEnergy())
                {
                    Console.WriteLine("устал. все.");
                    break;
                }
            }
            Console.WriteLine($"{FullName} пришел");
        }

        private bool CheckEnergy()
        {
            energy--;
            if (energy <= 0)
            {
                return false;
            }
            return true;
        }

        public void Greeting(Human human)
        {
            Console.WriteLine($"{FullName} greeting to {human.FullName}");
        }

        public static void Greeting(Human first, Human second)
        {
            Console.WriteLine($"{first.FullName} greeting to {second.FullName}");
        }

        public override string ToString()
        {            
            return $"{FullName}, {Age}";
        }
    }
}
