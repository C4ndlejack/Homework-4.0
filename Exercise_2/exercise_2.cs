// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

using System;
{
    int[] toIntegerArray (int number)
{
    int a = number;
    List<int> i = new List<int>();
    while(a > 0)
    {
            i.Add(a % 10);
            a = a / 10; 
    }
    return i.ToArray();
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int [] array = toIntegerArray(number);
Console.WriteLine("Сумма цифр введенного числа: ");
int j = 0;
int result = 0;
while(j < array.Length)
{
    result += array[j];
    j++;
}
Console.WriteLine(result);
}