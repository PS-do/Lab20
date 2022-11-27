using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    internal class Program
    {
        delegate int MyDelegate (int a, int b);
        static void Main(string[] args)
        {
            //MyDelegate myDelegate = PowerAB;
            //Console.WriteLine(myDelegate(2, 10));

            //myDelegate=PowerBA;
            //Console.WriteLine(myDelegate(2, 10));
            //////__________
            
            MyDelegate myDelegate = PowerAB;
            myDelegate += PowerBA;
            myDelegate(2, 10);

           //
            Console.ReadKey();
        }

        static int PowerAB(int a, int b)
        {
            int r = (int)Math.Pow(a, b);
            Console.WriteLine(r);
            return r;
        }
        static int PowerBA(int a, int b) 
        {
            int r = (int)Math.Pow(b, a);
            Console.WriteLine(r);
            return r;
        }
        //{
        //    //int p = 1;
        //    //for (int i = 0; i < b; i++)
        //    //{
        //    //    p *= a;
        //    //}
        //    //return p;
        //    //return (int)Math.Pow(a, b);

        //    return (int)(Math.Round( Math.Pow(a, b)));
        //}
    }
}
