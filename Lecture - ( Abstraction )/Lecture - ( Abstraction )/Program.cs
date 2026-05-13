using System;
namespace A
{
    public abstract class P1
    {
        public abstract void M1();

        //Non-Abstract method which we called directly
        public void M2()
        {
            Console.WriteLine("Called Normal Method");
        }
    }

    public class B1 : P1
    {
        public override void M1()
        {
            Console.WriteLine("This is method inside B1 class");
        }
    }

    public class B2 : P1
    {
        public override void M1()
        {
            Console.WriteLine("Method invoked inside B2 class");
        }
    }

    class ABC
    {
        public static void Main(String[] args)
        {
            P1 obj;
            obj = new B1();
            obj.M1();
            obj = new B2();
            obj.M1();
            obj.M2();

            Console.ReadLine();
            
        }
    }
}