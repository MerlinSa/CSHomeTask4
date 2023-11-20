//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System;
using System.Globalization;
public class UsingWhile
{
    public static void Main()
    {
        Console.WriteLine("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int summ = 0;

        string strNumber = number.ToString(); // преобразуем число в строку
        for (int i = 0; i < strNumber.Length; i++)
        {
            summ = summ + (strNumber[i] - '0'); // табличное значение символа 0, ASCII
        }
        char mySymb = Console.ReadKey().KeyChar;
        
        while (true)
        {
            if (summ % 2 == 0)
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            if (mySymb == 'q')   break;// Проверяем, является ли введенная строка символом 'q' //  у меня это не сработало, не пойму никак!!!

            else
            {
                Console.WriteLine("Введите целое число: ");

            }

        }

    }

}

