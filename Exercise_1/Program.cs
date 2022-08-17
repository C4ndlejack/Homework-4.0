// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

using System;
{
    double [] array = {0, 0};
    Console.WriteLine("Введите основание степени: ");
    array[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите показатель степени: ");
    array[1] = Convert.ToDouble(Console.ReadLine());
    double j = array[0];
    double i = 1;
    double result = 1;
    while (i <= array[1])
    {
        result = result * j;
        array[0] = result;
        i++;
    }
    Console.WriteLine("Результат: ");
    Console.WriteLine(result);
}
