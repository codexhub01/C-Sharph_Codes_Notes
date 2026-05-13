using System;
namespace A
{
    //Basic Inheritance
    class C1
    {
        public void M1()
        {
            Console.WriteLine("Method M1 which is inside C1 class");
        }
    }

    class C2 : C1
    {
        public void M2()
        {
            Console.WriteLine("Method M1 which is inside C2 class");
        }
    }


    class ABC
    {
        public static void Main(String[] args)
        {
            //Basic Inheritance
            C2 c = new C2();
            c.M1();
            c.M2();


















            Console.ReadLine();
        }
    }
}