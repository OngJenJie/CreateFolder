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
            Console.WriteLine("請輸入你想要創造多少文件夾：");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string dirPath = @"C:\test\file" + i;

                if (Directory.Exists(dirPath))
                {
                    Console.WriteLine("▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅");
                    Console.WriteLine("▉                                         ▉");
                    Console.WriteLine("▉    The directory {0} already exists.    ▉", dirPath);
                    Console.WriteLine("▉                                         ▉  ");
                    Console.WriteLine("▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅");
                }
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
