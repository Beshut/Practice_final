using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        String line;
        StreamReader str = new StreamReader("C:\\Users\\User\\Documents\\X.txt");
        line = str.ReadLine();
        str.Close();
        line = line.Replace("(", "");
        line = line.Replace(")", "");
        line = line.Replace(";", " ");
        var str_mas = line.Split(' ');
        double[] M = new double[str_mas.Length];
        int j = 1;
        for (int i = 0; j < str_mas.Length; i++)
        {
            M[i] = Convert.ToDouble(str_mas[j]);
            j = j + 2;
        }
        string[] M1 = new string[M.Length];

        int a;
        double len = (double)M.Length / 2 - M.Length / 2;
        if (len != 0)
        {
            a = M.Length / 2;
        }
        else
        {
            a = M.Length / 2;
        }

        for (int i = 0; i < a; i++)
        {
            M1[i] = M[i].ToString();
        }

        string M2 = "";
        for (int i = 0; i < a; i++)
        {
            if (i == 0)
                M2 = M2 + M1[i];
            else
                M2 = M2 + " " + M1[i];
        }
        M2 = M2.Insert(0, "(");
        M2 = M2.Insert(M2.Length, ")");
        M2 = M2.Replace(" ", ";");
        StreamWriter sw = new StreamWriter("C:\\Users\\User\\Documents\\Y.txt");
        sw.WriteLine(M2);
        sw.Close();
    }
}
