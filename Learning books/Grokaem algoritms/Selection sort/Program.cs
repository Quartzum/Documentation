//Алгоритм сортировки выбором

void Main()
{
    Console.WriteLine("Start Selection Sort");
    int[]array = { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 }; //Инициализация неотсортированного массива.
    SelectionSort(array);
    PrintArray(array);
}
int[]SelectionSort(int[]array)
{
    int temp = 0;
    int smallest = 0;

    for (int i = 0; i < array.Length; i++)// Создаем первый цикл, чтобы обойти весь массив.
    {
        smallest = i; //Переменной smallest присваиваем индекс минимального значения.
        for (int j = i + 1; j < array.Length; j++)//j делаем больше i, чтобы взять соседнее число.
        {
            if (array[j] < array[smallest]) //Проверяем соседнее число, что оно меньше другого соседнего числа.
            {
                smallest = j; // Если условие верно, то теперь минимальное число будет находится на индексе j.
            }
        }
        temp = array[smallest];//Заносим минимальное число в коробку temp
        array[smallest] = array[i];//Заносим на вторую позицию число находщееся на индексе i
        array[i] = temp; // Заносим на первую позицию минимальное число из temp
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