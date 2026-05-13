using System;
namespace Type_Casting
{
    class ABC
    {
        public static void Main(String[] args)
        {
            int a = 100;
            //Implicit TypeCasting
            long b = a;
            Console.WriteLine(b);

            long c = 10;
            //EXplicit TypeCasting
            Console.WriteLine(Convert.ToInt32(c));
        }
    }
}