using System;
namespace A
{
    static class SC
    {
        //Static class contains only static members
        public static void M1()
        {
            Console.WriteLine("Method inside Static class");
        }

        //In this we directly set values because there's no object can create of an static class
        public static int P1 { get; set; } = 100;

        //Static Constructor
        static SC()
        {
            Console.WriteLine("Static Constructor");
        }
    }
    class ABC
    {
        public static void Main(String[] args)
        {
            SC.M1();
            SC.P1 = 182;
            Console.WriteLine("Getting value of property : " + SC.P1); 
            


            Console.ReadLine();
        }
    }
}