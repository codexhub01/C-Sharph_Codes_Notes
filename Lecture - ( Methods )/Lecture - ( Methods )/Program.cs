using System;
namespace ABC
{
    class mob
    {
        public void M1()
        {
            Console.WriteLine("Hey this method is inside mob class");
        }
    }
    class A
    {
        public static void M2()
        {
            Console.WriteLine("Hey this method is inside A class & method is M2");
        }
        public static void Main(String[] args)
        {
            //To just call normal method
            mob mb = new mob();
            mb.M1();
            
            //To just call M2 method
            A.M2();

            Console.ReadLine();
        }
    }
}