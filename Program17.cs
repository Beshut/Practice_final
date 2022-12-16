using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        string line;
        StreamReader str = new StreamReader("C:\\Users\\User\\Documents\\input.txt");
        line = str.ReadLine();
        str.Close();
        string line1 = line;
        var index = new List<int>();
        char c = ' ';
        int k = 0;
        int j = 0;
        foreach (char cr in line)
        {
            if (cr == c)
            {
                index.Add(k);
                j++;
            }
            k++;
        }

        line = Regex.Replace(line, @"[^\w\s]*", String.Empty);

        string[] strarr = line.Split(' ');
        string[] digits = strarr.Where(x => Regex.IsMatch(x, @"^\d+$")).ToArray();

        int sum = 0;
        string M2 = "";
        for (int i = 0; i < digits.Length; i++)
        {
            if (i == 0)
                M2 = M2 + digits[i];
            else
                M2 = M2 + " " + digits[i];
        }

        string[] words = M2.Split(' ');
        int[] ints = Array.ConvertAll(words, int.Parse);

        for (int i = 0; i < ints.Length; i++)
        {
            sum += ints[i];
        }
        StreamWriter sw1 = new StreamWriter("C:\\Users\\User\\Documents\\input.txt");
        sw1.WriteLine(line1);
        sw1.WriteLine("Сумма чисел = {0}", sum);
        sw1.Close();
    }
}
