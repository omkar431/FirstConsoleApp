using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp
{
    class Class1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Please provide your value for a");
            string val_a = Console.ReadLine();
            int a = Convert.ToInt32(val_a);
            Console.WriteLine("Please provide your value for b");
            string val_b = Console.ReadLine();
            int b = Convert.ToInt32(val_b);
            Console.WriteLine("Please provide your value for c");
            string val_c = Console.ReadLine();
            int c = Convert.ToInt32(val_c);
            float s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("Area Of Triangle is" + area);
        }
    }
}
