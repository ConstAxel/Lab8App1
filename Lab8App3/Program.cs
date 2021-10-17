using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8App3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вручную подготовьте текстовый файл с фрагментом текста.Напишите программу, которая выводит статистику по файлу -количество символов, строк и слов в тексте.
            string path = @"D:\Users\ConstAxel\Desktop\ДЛЯ ПРИМЕРОВ\Занятие 8. Работа с файловой системойСтраница\Lab8App1\Lab8App3\Text.txt";
            StreamReader Text = new StreamReader(path);
            string S = Text.ReadToEnd();
            Console.WriteLine($"Текст:\n{S}\n");
            int Str = 0;
            int Sym = 0;
            int Word = 0;
            foreach (string lines in File.ReadLines(path))
            {
                Str++;
                string[] Words = lines.Split();
                foreach (string words in Words)
                {
                    Word++;
                }
                char[] chars = lines.ToCharArray();
                foreach (char sym in chars)
                {
                    Sym++;
                }
            }
            Console.WriteLine($"Строк:\n{Str}");
            Console.WriteLine($"Слов:\n{Word}");
            Console.WriteLine($"Символов:\n{Sym}");
            Console.ReadKey();

        }
    }
}
