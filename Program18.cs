using System;
class Program
{
    static string Perevorot(string str)
    {
        string temp = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            temp += str[i];
        }
        return temp;
    }

    static void Main(string[] args)
    {
        Console.Write("Введите текст: ");
        string str = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Текст наоборот: {0}", Perevorot(str));
        Console.ReadKey();
    }
}
