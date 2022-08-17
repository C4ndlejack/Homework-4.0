// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

using System;
{
    Console.WriteLine("Введите размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] array = new int [n];
    Random rand = new Random();
    Console.WriteLine("Результат: ");
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 50);
        Console.Write(array[i] + " ");
    }
}    