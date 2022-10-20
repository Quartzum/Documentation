/*
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]

*/

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[] fill = GetArray(10, 0, 10);
    PrintArray(fill);
    Console.WriteLine();
    ReversArray1(fill);
    PrintArray(fill);
    Console.WriteLine();
    ReversArray2(fill);
    PrintArray(fill);
    Console.WriteLine();
    Console.WriteLine("End");
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void ReversArray1(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i]; // первый элемент по счетчику ложим в к.
        inArray[i] = inArray[inArray.Length - 1 - i];//Последний элемент.
        inArray[inArray.Length - 1 - i] = k;
    }
}

int[] ReversArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}
Main();