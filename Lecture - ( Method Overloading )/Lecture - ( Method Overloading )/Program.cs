using System;
namespace A
{
    class C1
    {
        public void M1()
        {

        }
        public void M1(int no , string name)
        {
            Console.WriteLine("Method M1 which contains no & name");
        }
        public void M1(string name , int no)
        {
            Console.WriteLine("Method M1 which contains no & name in different order as compare to previously");
        }

        public void M1(int no, string name , string add)
        {
            Console.WriteLine("Method M1 which contains more counted element");
        }
    }
    class ABC
    {
        public static void Main(String[] args)
        {
            C1 c1 = new C1();

            c1.M1();
            c1.M1(10, "Mayank");
            c1.M1("Roy", 100);
            c1.M1(287, "Omkara", "Dwarka");

            Console.ReadLine();
        }
    }
}