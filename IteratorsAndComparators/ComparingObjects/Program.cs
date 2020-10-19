using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            while (true)
            {

                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                var parts = input.Split();
                var person = new Person(parts[0], int.Parse(parts[1]), parts[2]);
                list.Add(person);
            }
            int n = int.Parse(Console.ReadLine());
            int matchCounter = 0;
            int notMatchCounter = 0;
            foreach (var person1 in list)
            {
                if (person1.CompareTo(list[n - 1]) == 0)
                {
                    matchCounter++;
                }
                else
                {
                    notMatchCounter++;
                }
            }
            if (matchCounter == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matchCounter} {notMatchCounter} {list.Count}");
            }
        }
    }
}
