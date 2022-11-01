// Простой алгоритм

void Simple()
{
    Console.Clear();
    Console.WriteLine("Start Simple Algoritm");
    int[]SortArray = {1,2,3,4,5,6,7,8,9};// Инициализация отсортированного массива.
    int[]UnsortArray = {1,2,5,4,5,0,7,7,9};// Инициализация неотсортированного массива.
    int searching = 9;// Инициализация искомого значения.
    Console.WriteLine($"Количество итераций простого алгоритма для отсортированного массива = {SimpleSearch(SortArray, searching)}");
    Console.WriteLine();
    Console.WriteLine($"Количество итераций простого алгоритма для неотсортированного массива = {SimpleSearch(UnsortArray, searching)}");
    Console.WriteLine();
    Console.WriteLine("End Simple Algoritm");
}
int SimpleSearch(int[]array, int searching)
{
    int result = 1;// Инициализация счётчика итераций алгоритма.
    
    for(int i = 0; i < array.Length;i++)// Цикл проходится по каждому элементу массива.
    {
        if(array[i] == searching) return result; // Если элемент находящийся на текущем индексе = искомому числу, то ВОЗВРАЩАЕМ его...
        result++;
        // ...иначе переходим к следующей итерации.
    }
    return -1; // Если число не найдено ВОЗВРАЩАЕМ -1.
}
Simple();

//Бинарный алгоритм
void Binary()
{
    Console.WriteLine();
    Console.WriteLine("Start Binary Algoritm");
    int[]arrayBinary = {1,2,3,4,5,6,7,8,9}; // Инициализация отсортированного массива(БИНАРНЫЙ АЛГОРИТМ РАБОТАЕТ ТОЛЬКО С ОТСОРТИРОВАННЫМ МАССИВОМ!).
    int searchingBinary = 2; // Инициализация искомого числа.
    Console.WriteLine($"Количество итераций бинарного алгоритма = {BinarySearch(arrayBinary, searchingBinary)}");
    Console.WriteLine("End Binary Algoritm");
}
int BinarySearch(int[]array, int searching)
{
    int low = 0;// Индекс начала массива.
    int high = array.Length-1;// Индекс конца массива.
    int result = 1; // Инициализация счётчика итераций алгоритма.
    
    while(low <= high)// 1. Делит массив пополам. 2. Сравнивает искомое число с серединой массива. 3. Определяет границы массива.
    {
        int mid = (low + high) / 2; // Инициализация середины массива.

        if(searching == array[mid]) return result; // Если искомое число = середине массива, то ВОЗВРАЩАЕМ ...
        else if(searching < array[mid]) high = mid-1; // Также если, искомое число > середины массива, то конец массива = середина массива - 1;
        else low = mid + 1; // Иначе начало массива = середина массива + 1;
        result++;
        // ...иначе переходим к следующей итерации.
    }
    return -1; //Вернуть -1, если искомого значения нет.
    
}
Binary();

/*О-большое линейного алгоритма - О(n). Т.е., если у нас есть массив из 100 элементов,
то сложность его выполнения будет - 100 итераций.
О-большое бинарного алгоритма - 7 итераций.

О-большое - самый худший сценарий, при котором будет найдено искомое. Т.е. за какое количество максимальных
итераций будет найдено искомое число.
*/
