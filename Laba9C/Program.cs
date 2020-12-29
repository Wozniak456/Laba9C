using System;
using MyLib;

namespace Laba9C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть символiв, яку не має перевищувати слово: ");
            int number_ = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine();
            Console.Write("Введiть рядок: ");
            string str_ = Console.ReadLine();
            string n_str = FirstLab.Novi_str(number_, str_);
            Console.WriteLine();
            Console.WriteLine($"Рядок iз вилученням слiв, у яких символiв менше нiж {number_}: {n_str}");
        }
    }
}
