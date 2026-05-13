using System;
namespace A
{
    class ABC
    {
        //This can not be modifed because of const
        const int num = 100;
        static string name = "roy";

        public static void Main(String[] args)
        {
            name = "Mayank";
           
            
        }
    }
}