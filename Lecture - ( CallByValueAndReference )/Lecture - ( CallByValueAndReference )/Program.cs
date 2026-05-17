namespace ABC
{
    class B
    {
        public void passed_by_val(int val)
        {
            Console.WriteLine(val);
        }

        public void passed_by_ref(ref int val)
        {
            val += 100;
            Console.WriteLine(val);
        }

        //public void passed_by_out(out int a)
        //{
        //    //a += 100;
        //    Console.WriteLine(val);
        //}
    }

    class A
    {
        public static void Main(string[] args)
        {
            B b = new B();
            b.passed_by_val(1);

            //passed  by ref
            int x = 12;
            b.passed_by_ref(ref x);
            Console.WriteLine(x);



            Console.ReadLine();
        }
    }
}


/*
    
When we pass variables into methods , C# pass them in mainly two ways
-> Call by value ( copy passed )
-> Call by refrence ( actual variable refrence passed )

Call By value :-
-> copy of variable is passed to method
-> original variable does not change because method works on copied value
-> Must intialize before pass
-> It usually stored in stack
-> Stack copy created

Call By Reference :-
-> Actual variable reference/address passed into method
-> Affect original variable
-> use using ref keyword
-> Same stack location refrenced

Out Keyword:-
-> It also use refrence passing
-> No intialization needed


 */