using System;
namespace A
{
    class GM<T>
    {
        public static void M1<T>(T _vble)
        {
            Console.WriteLine(_vble + " is passed");
        }
    }
    class ABC
    {
        public static void Main(String[] args)
        {
            GM<int>.M1(100);

            Console.WriteLine("After calling method through int value");

            GM<string>.M1("roy");

            Console.ReadLine();
        }
    }
}