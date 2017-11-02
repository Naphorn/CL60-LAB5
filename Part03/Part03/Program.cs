using System;

namespace Part03
{
    class Program
    {
        static void Main(string[] args)
        {
            double GPA = 1.95;
            Console.WriteLine("You are " + (GPA >= 2.0 ? "pass" : "fall"));
        }
    }
}
