using System;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T>
    {
        public Box(T input)
        {
            this.Input = input;
        }
        public T Input { get; set; }
        public Type Type => typeof(T);
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Type}: {Input}");
            return sb.ToString().TrimEnd();
        }
    }
}
