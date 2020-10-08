using System;

namespace FilterByAge
{
    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ");
                people[i] = new Person(input[0], int.Parse(input[1]));
            }
            string condition = Console.ReadLine();
            int filterAge = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person, bool> delegateCondition = GetCondition(condition, filterAge);
            Action<Person> printer = GetPrinter(format);
            FilterPrinter(people, delegateCondition, printer);
        }
        static void FilterPrinter(Person[] people, Func<Person, bool> conditions,
           Action<Person> printer)
        {
            foreach (var person in people)
            {
                if (conditions(person))
                {
                    printer(person);
                }
            }
        }
        static Action<Person> GetPrinter(string format)
        {
            if (format == "name")
            {
                return x => Console.WriteLine(x.Name);
            }
            else if (format == "age")
            {
                return x => Console.WriteLine(x.Age);
            }
            else if (format == "name age")
            {
                return x => Console.WriteLine($"{x.Name} - {x.Age}");
            }
            else
            {
                return null;
            }
        }
        static Func<Person, bool> GetCondition(string condition, int age)
        {
            if (condition == "younger")
            {
                return x => x.Age < age;
            }
            else if (condition == "older")
            {
                return x => x.Age >= age;
            }
            else
            {
                return null;
            }
        }
    }
}
