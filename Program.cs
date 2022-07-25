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
        // Функция ищет слова текста, которые содержат только большие буквы алфавита.
        static string FindAndWrite(string[] myWords)
        {
            string newString = "";
            for (int i = 0; i < myWords.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < myWords[i].Length; j++)                
                    if (char.IsUpper(myWords[i][j]) == false)
                    {
                        flag = false;
                        break;
                    }                
                if (flag)
                    newString += myWords[i] + " ";
            }
            return newString;
        }

        static void Main(string[] args)
        {
            string myString = "ABCD AShfsdjkal Abn hfds АБВГД ФaФ";
            string newString = FindAndWrite(StringToWords(myString));
            Console.WriteLine(newString);
            Console.ReadKey();
        }
    }
}
