using System;
namespace A
{
    class GT<T>
    {
        private T _vble;
        public GT(T vble)
        {
            this._vble = vble;
        }
        public T M1()
        {
            return this._vble;
        }
    }
    class ABC
    {
        public static void Main(String[] args)
        {
            GT<int> obj = new GT<int>(100);
            Console.WriteLine("After passing integer : " + obj.M1());

            GT<string> obj1 = new GT<string>("Mayank");
            Console.WriteLine("After passing string : " + obj1.M1());

            Console.ReadLine();
        }
    }
}