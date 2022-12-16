using System;
using System.Linq;
class Program
{
    public static void Procedure(int n)
    {
        string str;
        for (int i = 1; i <= n; i++)
        {
            str = String.Concat(Enumerable.Repeat("m", i));
            Console.WriteLine("{0}", str);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Количество символов: ");
        var n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Procedure(n);
        Console.ReadKey();
    }
}
