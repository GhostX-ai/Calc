using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Functions<C>
    {
        static public C plus(C x, C y)
        {
            return (dynamic)x + (dynamic)y;
        }
        static public C minus(C x, C y)
        {
            return (dynamic)x - (dynamic)y;
        }
        static public C divide(C x, C y)
        {
            return (dynamic)x / (dynamic)y;
        }
        static public C multiplus(C x, C y)
        {
            return (dynamic)x * (dynamic)y;
        }
    }
}
