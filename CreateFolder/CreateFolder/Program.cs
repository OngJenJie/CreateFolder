using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateFolder
{
    class Program
    {
        static void Main(string[] args)
        {

            // 讓使用者輸入文件夾數量
            Console.WriteLine("請輸入你想要創造多少文件夾：");
            int count = int.Parse(Console.ReadLine());

            // 創建數個文件夾
            for (int i = 0; i < count; i++)
            {

                // 設定地點
                string dirPath = @"C:\test\file" + i;

                // 如果那個位置已經存在文件夾就通知他
                if (Directory.Exists(dirPath))
                {
                    Console.WriteLine("▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅");
                    Console.WriteLine("▉                                         ▉");
                    Console.WriteLine("▉    The directory {0} already exists.    ▉", dirPath);
                    Console.WriteLine("▉                                         ▉  ");
                    Console.WriteLine("▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅");
                }

                // 如果沒有就創建文件夾
                else
                {
                    Directory.CreateDirectory(dirPath);
                    Console.WriteLine("▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅");
                    Console.WriteLine("▉                                         ▉");
                    Console.WriteLine("▉    The directory {0} was created.       ▉", dirPath);
                    Console.WriteLine("▉                                         ▉  ");
                    Console.WriteLine("▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅");
                }
            }
            Console.ReadKey();
        }
    }
}
