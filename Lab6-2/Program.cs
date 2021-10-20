using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку для проверки: ");
            string str = Console.ReadLine();
            string[] words = str.Split();
            string str1 = String.Join("", words);
            string str2 = String.Join("", str1.Reverse());
            
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            if (String.Compare(str1.ToLower(), str2.ToLower())==0)
                Console.WriteLine("Палиндром");
            else
                Console.WriteLine("Не палиндром");
                
            Console.ReadLine();
        }
    }
}
