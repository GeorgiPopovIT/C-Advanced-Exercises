﻿using System;

namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string niz = Console.ReadLine();
                Box<string> box = new Box<string>(niz);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
