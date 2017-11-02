using System;

namespace Part03
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            string helloWorld = hello + world;
            Console.WriteLine(helloWorld);
            string helloWorld555 = helloWorld + " " + 555;
            Console.WriteLine(helloWorld555);
        }
    }
}
