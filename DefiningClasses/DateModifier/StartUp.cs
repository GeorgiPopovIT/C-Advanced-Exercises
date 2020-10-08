using System;
using System.Linq;

namespace DateModifier
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var date1 = Console.ReadLine().Split().ToArray();
            var date2 = Console.ReadLine().Split().ToArray();
            DateModifier date = new DateModifier();
            Console.WriteLine(date.CalculateDiffrence(date1, date2));

        }
    }
}
