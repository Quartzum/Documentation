// Алгоритм быстрой сортировки(алгоритм Хоара)

void Main()
{
    Console.Clear();
    Console.WriteLine("Start algorithm QuickSort");
    int[] array = { 4, -12, 3, 31, 0, 7, 4, 14, 90, 5, 9 }; // Инициализация неотсортированного массива.
    PrintArray(array); // Печать неотсортированного массива.
    array = QuickSort(array, 0, array.Length - 1); // Сортировка массива.
    PrintArray(array); // Печать отсортированного массива.
    Console.WriteLine("End algorithm QuickSort");
}
int[] QuickSort(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return array;

    int pivot = FindPivot(array, minIndex, maxIndex);
    Console.WriteLine($"Опорный индекс - {pivot}");
    QuickSort(array, minIndex, pivot - 1);
    QuickSort(array, pivot + 1, maxIndex);

    return array;
}
int FindPivot(int[] array, int minIndex, int maxIndex) // Передаем - массив, минимальный индекс, максимальный индекс.
{
    int pivot = minIndex - 1; //Опорная позиция.
    int temp = 0; // Переменная для хранения опорной позиции при перестановки.
    
    for (int i = minIndex; i < maxIndex; i++)
    {
        if (array[i] < array[maxIndex])
        {
            pivot++;
            temp = array[pivot];
            array[pivot] = array[i];
            array[i] = temp;
        }
    }

    pivot++;
    temp = array[pivot];
    array[pivot] = array[maxIndex];
    array[maxIndex] = temp;

    return pivot;
}
void PrintArray(int[] array) // Метод печати массива в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Main();