using System;

namespace Part03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double d = 5e9d;
                Console.WriteLine(d);
                int i = (int)d;
                Console.WriteLine(i);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}