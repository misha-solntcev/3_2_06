using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Вариант 6
Дана строка.Словом текста считается любая последовательность букв; между
соседними словами - не менее одного пробела, за последним словом - точка. Найти и
сохранить в строке те слова текста, которые содержат только большие буквы алфавита.
Все остальные слова удалить.*/

namespace _3_2_06
{
    internal class Program
    {
        // Функция разбивает строку на массив слов.
        static string[] StringToWords(string myString)
        {
            char[] sep = { ' ', '.' };
            string[] myWords = myString.Split(sep, StringSplitOptions.RemoveEmptyEntries);            
            return myWords;
        }


        static void Main(string[] args)
        {
            string myString = "dsgajk AShfsdjkal Abn hfds";            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
