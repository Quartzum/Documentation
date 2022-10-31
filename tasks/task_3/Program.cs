/* Найдите максимальное число в отсортированном одномерном массиве*/

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[]array = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
    int searching = GetNumber();
    Console.WriteLine($"Индекс искомого числа: {searching} - {BinaryAlgoritmh(array, searching)}.");
    Console.WriteLine("End");
}
int GetNumber()
{
    Console.Write("Введите искомое число массива: ");
    return int.Parse(Console.ReadLine());
}
int BinaryAlgoritmh(int[]array, int searching)
{
    int min = 0;
    int max = array.Length-1;
    
    while(min <= max)
    {
        int mid = (min + max) / 2;
        if(searching == array[mid])return mid;
        if(searching < array[mid])max = mid - 1;
        else min = mid + 1;
    }
    return -1;
}
Main();