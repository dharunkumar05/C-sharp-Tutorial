
using System;

class Methods
{
    static void Main()
    {
        int adds(int a , int b)
        {
            return a+b;
        }

        void call(Func<int,int,int> callback)
        {
            Console.WriteLine(callback(2,8));
        }
        call(adds);

        void add (ref int a)
        {
            a=30;
        }
        int x = 10;
        add(ref x);
    }
}