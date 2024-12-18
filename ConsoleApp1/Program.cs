
using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку для проверки на палиндром:");
        string input = Console.ReadLine();

        if (Check.IsPalindrome(input))
        {
            Console.WriteLine("Строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом.");
        }
    }


}