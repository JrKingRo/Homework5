/*
 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Введите длинну массива: ");
int len = int.Parse(Console.ReadLine());


int[] getArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;

}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i] + " ");
    }
    Console.WriteLine();
    return;
}
int sum = 0;
int[]array = getArray(len);

PrintArray(array);

for (int i = 1; i < len; i+=2)
{
    sum = array[i] + sum;
}

Console.WriteLine("Сумма нечетных позиций : " + sum);
