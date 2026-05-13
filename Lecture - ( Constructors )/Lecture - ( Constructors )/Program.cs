using System;
namespace ABC
{
    class B
    {
        private B()
        {

        }
    }

    class S
    {
       static S()
        {
            Console.WriteLine("Static Constructor");
        }
    }

    class A
    {
        int num;
        string sg;

        //Default Constructor
        public A()
        {
            Console.WriteLine("Default Constructor");
        }

        //Parameterized Constructor
        public A(int no)
        {
            this.num = no;
        }

        //Copy Constructor  
        public A(A ab)
        {
            sg = ab.sg;
        }
        public A(string s)
        {
            this.sg = s;
        }

        public string GSD
        {
            get
            {
                return "My string is : " + sg + " " + "( get from copy constructor )";
            }
        }

        
        public static void Main(String[] args)
        {
            //Default Cons
            A obj = new A();

            //Parameterized const
            A obj2 = new A(100);
            Console.WriteLine("Values setted through parameterized constructor : " + obj2.num);

            //Copy Constructor
            A obj3 = new A("Mayank");
            A obj4 = new A(obj3);
            Console.WriteLine(obj4.GSD);


            //Private Constructor
            //B obj = new B() :- this is not possible to do over here because we already have created priate constructor in B class 

            //Static Constructor
            S obj5 = new S();


            Console.ReadLine();
        }
    }
}