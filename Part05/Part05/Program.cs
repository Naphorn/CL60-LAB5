using System;
namespace Part05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter width : ");
                double w = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter length : ");
                double l = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter height : ");
                double h = Convert.ToDouble(Console.ReadLine());

                Area(w, l, h);
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

        static void Area(double w, double l, double h)
        {
            double a = ((w + l) * h) * 1 / 2;
            Console.WriteLine("Result = {0} cm^2", a);
        }
    }
}