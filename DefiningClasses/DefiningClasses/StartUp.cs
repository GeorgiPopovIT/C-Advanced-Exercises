using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Family people = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                var name = input[0];
                var age = int.Parse(input[1]);
                var person = new Person(name, age);
                people.AddMember(person);
            }
            foreach (Person person1 in people.GetOldestMember())
            {
                Console.WriteLine(person1.ToString());
            }
        }
    }
}
