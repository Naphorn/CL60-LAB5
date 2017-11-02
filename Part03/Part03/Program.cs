using System;

namespace Part03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b);
            Console.WriteLine(a || b);
            Console.WriteLine(!b);
            Console.WriteLine(b || true);
            Console.WriteLine((9 > 7) ^ (a == b));
            Console.WriteLine((b != a) || (a == b));
            Console.WriteLine((b != a) && (a == b));
            Console.WriteLine((!a) && (!b));
            Console.WriteLine((!a) || (!b));
        }
    }
}
