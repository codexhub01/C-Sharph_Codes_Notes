using System;
namespace ABC
{
    class A
    {
        //Destructor this will automatically called , when all task done which are written inside main method
        ~A()
        {
            Console.WriteLine("Destructor called");
        }

        public void M1()
        {
            Console.WriteLine("Method 1 called");
        }

        public static void Main(string[] args)
        {
            A obj = new A();
            obj.M1();

            Console.ReadLine(); 
        }
    }
}