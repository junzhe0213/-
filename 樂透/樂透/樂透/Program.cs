using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 樂透
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int j = 9;
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 10; i++)
            {

                    Console.WriteLine("還剩下" + j + "次");
                    int r1 = r.Next(1, 49);
                    int r2 = r.Next(1, 49);
                    int r3 = r.Next(1, 49);
                    int r4 = r.Next(1, 49);
                    int r5 = r.Next(1, 49);
                    int r6 = r.Next(1, 49);
                    Console.WriteLine("┌──── 大樂透開獎時間────┐");
                    Console.WriteLine("│                       │");
                    Console.WriteLine("│                       │");
                    Console.WriteLine("│    {0:00} {1:00} {2:00} {3:00} {4:00} {5:00}  │", r1, r2, r3, r4, r5, r6);
                    Console.WriteLine("│                       │");
                    Console.WriteLine("│                       │");
                    Console.WriteLine("└───────────────────────┘");
                    Console.WriteLine("[請按Enter進行下一次開獎]");
                    Console.ReadLine();
                    j = j - 1;
                    Console.Clear();
            }
        }
    }
}
