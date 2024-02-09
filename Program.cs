using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1 число:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("a>b");
            }
            else if (a < b)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("a<b");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("a=b");
            }
            Console.ReadKey();
        }
    }
}
