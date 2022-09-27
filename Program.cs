using System;

namespace Operatoryarytmetyczneilogiczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______________________");
            Console.WriteLine("Operatory Arytmetyczne");
            Console.WriteLine("");
            int a = 2;
            int b = 3;
            int c = b + a;
            int e = a += b;
            int d = a+=1;
            //b - a, b * a, b / a, b % a reszta z dzielenia
            // a += b;
            // a -= b;
            // a += 1; = a++;   +1
            // a--; -1
            Console.WriteLine(e + " a+=b");
            Console.WriteLine(d + " a+=1");
            Console.WriteLine("______________________");
            Console.WriteLine("Operatory Logiczne");
            Console.WriteLine("");
            bool f = 2 > 1; // 2>=1
            bool g = 2 == 1;
            bool h = 2 != 1;
            bool i = 2 > 1 && 3 > 1;
            bool j = 2 > 1 || 3< 1;
            Console.WriteLine(f + " 2>1?");
            Console.WriteLine(g + " 2==1?");
            Console.WriteLine(h + " 2!=1?");
            Console.WriteLine(i + " 2>1 && 3>1");
            Console.WriteLine(j + " 2 > 1 || 3 < 1");
            Console.ReadKey();
        }
    }
}