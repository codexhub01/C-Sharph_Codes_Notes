using System;
namespace A
{
    class ABC
    {
        
        public static void Sum(out int G , out int no)
        {
            G = 80;
            G += G;
            no = 21;
            no *= 100;
        }

        public static void SUB(ref int vale , ref int G)
        {
            vale *= 2110; 
        }
        public static void Main(String[] args)
        {
            int G;
            int no;
            Sum(out G , out no);
            SUB(ref no , ref G);
            Console.WriteLine("The sum of" +
                    " the value is: {0}", G);
        }

        
    }
}