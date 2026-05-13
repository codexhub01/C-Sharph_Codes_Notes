using System;
namespace A
{
    class C1
    {

        //And constructor will call first because they will call during creating of an object
        public virtual void M1()
        {
            Console.WriteLine("Method inside C1 class");
        }

        public C1(string name)
        {
            Console.WriteLine("Parameterize constructor which is in parent class");
        }
    }
    class C2 : C1
    {
        public override void M1()
        {

            //calling method of parent class 
            base.M1();

            Console.WriteLine("Method inside C2 class");

            
        }

        // We have just create constructor of child class too and calling constructor of parent class just by here 
        public C2(string name) :base(name)
        {
            Console.WriteLine("Constructor of child class");
        }
    }
    class ABC
    {
        public static void Main(String[] args)
        {
            C2 ob = new C2("");
            
            //calling method of derived or child class
            ob.M1();


            Console.ReadLine();
        }
    }
}