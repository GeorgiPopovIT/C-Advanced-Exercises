using System;
using System.Data;
using System.Linq;

namespace DateModifier
{
    public class DateModifier
    {
        public double CalculateDiffrence(string[] date1,string[] date2)
        {
            var arr1 = date1.Select(int.Parse).ToArray();
            var arr2 = date2.Select(int.Parse).ToArray();

            var firstTime = new DateTime(arr1[0], arr1[1], arr1[2]);
            var secondTime = new DateTime(arr2[0], arr2[1], arr2[2]);

            var diffrence = Math.Abs((firstTime - secondTime).TotalDays);
            return diffrence;
        }
    }
}
