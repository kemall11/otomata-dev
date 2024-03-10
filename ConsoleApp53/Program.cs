using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = RecursiveFunction(8, 'q', "wa", 9, 2);
            Console.WriteLine("Sonuç: " + sonuc);
        }
        static int RecursiveFunction(int multiplier, char input, string sequence, int a, int b)
        {
            if (sequence.Length == 0)
            {
                return multiplier * b;
            }
            else if (sequence[0] == 'q')
            {
                return RecursiveFunction(multiplier, sequence[1], sequence.Substring(2), multiplier * a, b);
            }
            else
            {
                return RecursiveFunction(multiplier, input, sequence.Substring(1), a, b);
            }
        }
    }
}
