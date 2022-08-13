/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Enter lenght : ");
int len = int.Parse(Console.ReadLine());

int[] getArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(100, 999);
    }
    return arr;

}
int counter = 0;

int[] arr = getArray(len);

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        counter++;
    }
    Console.Write(arr[i] + " ");

}
Console.WriteLine();
Console.WriteLine("Количество четных чисел: " + counter);