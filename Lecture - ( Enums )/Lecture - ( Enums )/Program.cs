using System;
namespace A
{
    class ABC
    {
        enum Books { cSharp, Javascript, Kotlin, Python, Java }

        //Change custom values and these values stores by default as a int and it increase by +1
        enum Name { roy , omkara = 12}

        //To Change type 
        enum Button : byte
        {

            
            OFF,
            
            ON
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Book: Java at Index:" + (int)Books.Java);
            Console.WriteLine("Book: Python at Index:" + (int)Books.Python);
            Console.WriteLine("Book: Kotlin at Index:" + (int)Books.Kotlin);
            Console.WriteLine("Book: Javascript at Index:" + (int)Books.Javascript);
            Console.WriteLine("Book: cSharp at Index:" + (int)Books.cSharp);

            byte b = 1;

            if(b == (Byte)Button.ON)
            {
                Console.WriteLine("All Okay");
            }
        }
    }
}