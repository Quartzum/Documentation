//Алгоритм сортировки выбором

void Main()
{
    Console.WriteLine("Start Selection Sort");
    int[]array = { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 }; // Инициализация неотсортированного массива.
    SelectionSort(array);
    PrintArray(array);
}
int[]SelectionSort(int[]array)
{
    int temp = 0; // Переменная для хранения минимального элемента.
    int smallest = 0; // Переменная для хранения минимального индекса.

    for (int i = 0; i < array.Length; i++)// Первый цикл перебирает каждый элемент массива.
    {
        smallest = i; //Минимальный индекс = текущему индексу(i).
        for (int j = i + 1; j < array.Length; j++)//Второй цикл перебирает каждый элемент, но с индекса i+1.
        {
            if (array[j] < array[smallest]) //Если элемент на индексе j < элемента с минимальным индексом,то ...
            {
                smallest = j; //Минимальный индекс = текущему индексу(j).
            }//...иначе повторяем цикл.
        }
        temp = array[smallest];//Помещаем в переменную наименьший элемент.
        array[smallest] = array[i];//Помещает на позицию, где был найден минимальный элемент - элемент находящийся на i индексе.
        array[i] = temp; // Помещает на текущий индекс - минимальный элемент.
    }
    return array;
}
void PrintArray(int[]array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"{array[i]}<-");
   }
}
Main();
