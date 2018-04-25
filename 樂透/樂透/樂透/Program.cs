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
            //設bang數
            Random r = new Random();
            int j = 9;
            //改字的顏色
            Console.ForegroundColor = ConsoleColor.Green;
            //迴圈10次
            for (int i = 0; i < 10; i++)
            {

                    //顯示剩幾次
                    Console.WriteLine("還剩下" + j + "次");
                    //設6個亂碼bang數
                    int r1 = r.Next(1, 49);
                    int r2 = r.Next(1, 49);
                    int r3 = r.Next(1, 49);
                    int r4 = r.Next(1, 49);
                    int r5 = r.Next(1, 49);
                    int r6 = r.Next(1, 49);
                    //顯示開獎數字
                    Console.WriteLine("┌──── 大樂透開獎時間────┐");
                    Console.WriteLine("│                       │");
                    Console.WriteLine("│                       │");
                    Console.WriteLine("│    {0:00} {1:00} {2:00} {3:00} {4:00} {5:00}  │", r1, r2, r3, r4, r5, r6);
                    Console.WriteLine("│                       │");
                    Console.WriteLine("│                       │");
                    Console.WriteLine("└───────────────────────┘");
                    Console.WriteLine("[請按Enter進行下一次開獎]");
                    Console.ReadLine();
                    //次數減一
                    j = j - 1;
                    //清除開獎結果
                    Console.Clear();
            }
        }
    }
}
