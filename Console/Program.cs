using System;

namespace TestConsole
{
    internal class Program
    {

        //delegate int AddDelegate(int a, int b);
        delegate string Concat(string a, String b);


        static void Main(string[] args)
        {

              Concat Concat = (c, d) => c + d;
            var result = Concat("Hello ", "World!");
            Console.WriteLine(result);


            //AddDelegate MultiTwo = (c, d) => c * d;

            //int result2 = MultiTwo(2, 2);
            //Console.WriteLine(result2);
        }
    }
}
