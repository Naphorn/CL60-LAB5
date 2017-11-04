using System;
namespace Part05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter weight : ");
                double w = Convert.ToDouble(Console.ReadLine());

                weight(w);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void weight(double w)
        {
            double a = (w * 1.6);
            Console.WriteLine("Weight = {0} N", a);
        }
    }
}