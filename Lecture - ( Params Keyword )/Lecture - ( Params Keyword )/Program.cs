using System;
using System.ComponentModel;
namespace Params_Keyword
{
    class A
    {
        public static int Add(params int[] arg)
        {
            int s = 0;
            foreach (int n in arg)
            {
                s += n;
            }
            return s;
        }

        //This is not allowed after params keyword , no other argument is alowed whether its of same type or of different type but yeah before it u can passed
        //public static void M1(params string[] arg, int no)
        //{

        //}

        public string Add_String(params string[] arg)
        {
            return string.Join(" ", arg);
        }

        public int Add_Integer(params int[] arg)
        {
            int c = 0;
            foreach (int v in arg)
            {
                c += v;
            }
            return c;
        }

        static void Main(String[] args)
        {
            int r = Add(1, 3, 5, 7, 9, 10);
            Console.WriteLine(r);
            A obj = new A();
            Console.WriteLine(obj.Add_String("M", "A", "Y", "A", "N", "K"));
            Console.WriteLine(obj.Add_String("1", "2", "3", "4"));
            Console.WriteLine(obj.Add_Integer(1, 2, 3, 4, 5));
            Console.ReadLine();
        }
    }
}