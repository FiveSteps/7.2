using System;

namespace zad7._2
{
    class Program
    {
        class Fuck
        {
            public int a;
            public int b;

            public void PrintNums()
            {
                Console.WriteLine("a = " + a + "\nb = " + b + "\n");
            }

            public void ChangeNums(int A, int B)
            {
                a = A;
                b = B;
            }

            public void Sum()
            {
                Console.WriteLine("a + b = " + (a + b) + "\n");
            }

            public void MaxNum()
            {
                if (a > b) Console.WriteLine(a + " > " + b + "\n");
                if (b > a) Console.WriteLine(b + " > " + a + "\n");
            }
        }
        static void Main(string[] args)
        {
            Fuck f = new Fuck();
            f.a = 12;
            f.b = 7;
            f.PrintNums();
            f.Sum();
            f.MaxNum();
            f.ChangeNums(5, 2);
            f.PrintNums();
            f.Sum();
            f.MaxNum();
        }
    }
}
