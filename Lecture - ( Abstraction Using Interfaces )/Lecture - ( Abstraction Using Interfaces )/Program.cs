using System;
namespace A
{
    interface I1
    {
        public void M1();
    }

    class C1 : I1
    {
        public void M1()
        {
            Console.WriteLine("This is an implementation of M1 which is present inside I1");
        }
    }
    class ABC
    {
        public static void Main(String[] args)
        {
            C1 c1 = new C1();
            c1.M1();
            Console.ReadLine();
        }
    }
}