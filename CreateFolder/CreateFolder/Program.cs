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
                string dirPath = @"C:\test\file";

                if (Directory.Exists(dirPath))
                {
                    Console.WriteLine("The directory {0} already exists.", dirPath);
                }
                else
                {
                    Directory.CreateDirectory(dirPath);
                    Console.WriteLine("The directory {0} was created.", dirPath);
                }
        }
    }
}
