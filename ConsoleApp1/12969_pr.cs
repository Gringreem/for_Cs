using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Example_12969
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        for(int i = 0; i < b; i++)
        {
            for(int j = 0; j < a; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}