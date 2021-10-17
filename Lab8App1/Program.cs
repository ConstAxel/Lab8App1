using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.
            string path = @"D:\Users\ConstAxel\Desktop\ДЛЯ ПРИМЕРОВ\Занятие 8. Работа с файловой системойСтраница\Lab8App1";
            if (Directory.Exists(path))
            {
                string[] subdirectories = Directory.GetDirectories(path);
                foreach (string s in subdirectories)
                {
                    Console.WriteLine("Подкаталоги");
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                string[] files = Directory.GetFiles(path);
                foreach (string p in files)
                {
                    Console.WriteLine("Файлы");
                    Console.WriteLine(p);
                }

            }
            Console.ReadKey();
        }
    }
}
