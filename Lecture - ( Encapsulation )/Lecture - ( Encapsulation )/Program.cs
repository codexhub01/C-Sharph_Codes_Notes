using System;
namespace A
{
    class ECP
    {
        private int _no;
        private string _name;

        public string M1(int no , string name)
        {
            this._name = name;
            this._no = no;
            
            return ("My name is : " + this._name + " And my no is : " + this._no);
        }

        public string P1
        {
            get
            {
                return this._name; 
            }
            set
            {
                this._name=value;
            }
        }
    }
    class ABC
    {
        public static void Main(String[] args)
        {
            ECP ob = new ECP();

            //Using Method
            Console.WriteLine("Using Method : "+( ob.M1(10,"Mayank Pal") ));

            //Using Properties
            Console.WriteLine("Using Properties : "+( ob.P1="Shivayee" ));
            Console.ReadLine();
        }
    }
}