using System;
namespace A
{
    class ABC
    {

        public static void M1(dynamic val)
        {
            Console.WriteLine("I am inside M1 method & calling from " + val.name);
        }

        public static void Main(String[] args)
        {
            //creating an anonymouse type of object & its type automatically generated based on data into object ( other than this not possible to cast ) during compile time
            var anonymous_data = new
            {
                name = "Anonymous type"
            };

            ABC.M1(anonymous_data);

            Console.ReadLine();
        }
    }
}