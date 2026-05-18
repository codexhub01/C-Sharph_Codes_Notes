using System;
namespace ABC
{
    class B
    {
        private int _id;

        public int G1S1
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
            }
        }

        public void M1(int no)
        {
            this.G1S1 = no;
        }

        //auto implemented property
        public int phoneno { get; set; }

        //short expression property
        public string name => "roy";
    }
    class A
    {
        public static void Main(String[] args)
        {
           B obj = new B();
            obj.M1(100);
           Console.WriteLine(obj.G1S1);
           Console.ReadLine();
        }
    }
}


/*
 
Properties :-
-> special members used to aceess & control class field safely
-> properties are basically combination of variables & methods
-> To controlled reading & writing

 */