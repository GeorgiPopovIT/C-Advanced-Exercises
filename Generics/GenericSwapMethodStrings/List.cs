using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class BoxStore<T>
    {
        private List<Box<T>> boxes;
        public BoxStore()
        {
            this.boxes = new List<Box<T>>();
        }
        public Type Type => typeof(T);

        public void Add(Box<T> element)
        {
            boxes.Add(element);
        }
        public  void SwapMethod(int index1, int index2)
        {
            Box<T> swap = boxes[index1];
            boxes[index1] = boxes[index2];
            boxes[index2] = swap;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Box<T> item in boxes)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
