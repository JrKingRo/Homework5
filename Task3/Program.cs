/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/


Console.WriteLine(" Введите длину массива : ");
int len = int.Parse(Console.ReadLine());


double[] GetArr(int len)
{
    double[] arr = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.NextDouble();
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i] + " ");
    }
    Console.WriteLine();
    return;
}


double[] arr = GetArr(len);
PrintArray(arr);

double min = arr[0];
double max = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];

    }
    Console.WriteLine("Максимальное значение : " + max);

    Console.WriteLine();

    if (arr[i] < min)
    {
        min = arr[i];
    }
    Console.WriteLine("Минимальное значение : " + min);
}

double result = max - min;
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным значением равна : " + result);