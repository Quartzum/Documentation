// Простой алгоритм

void Simple()
{
    Console.Clear();
    Console.WriteLine("Start Linear Algoritm");
    int[]array = {1,2,3,4,5,6,7,8,9};
    int searching = 9;
    Console.WriteLine($"Количество итераций линейного алгоритма = {SimpleSearch(array, searching)}");
    Console.WriteLine("End Linear Algoritm");
}
int SimpleSearch(int[]array, int searching)
{
    int count = 0;
    int result = 1;
    
    while(count < array.Length)
    {
        if(array[count] == searching) return result;
        count++;
        result++;
    }
    return -1;
}
Simple();

//Бинарный алгоритм
void Binary()
{
    Console.WriteLine();
    Console.WriteLine("Start Binary Algoritm");
    int[]arrayBinary = {1,2,3,4,5,6,7,8,9};
    int searchingBinary = 2;
    Console.WriteLine($"Количество итераций бинарного алгоритма = {BinarySearch(arrayBinary, searchingBinary)}");
    Console.WriteLine("End Binary Algoritm");
}
int BinarySearch(int[]array, int searching)
{
    int low = 0;//Первый индекс массива(начало)
    int high = array.Length-1;//Конец индекса массива(конец)
    int result = 1;
    
    while(low <= high)//Пока первый индекс меньше или равен концу массива
    {
        int mid = (low + high) / 2; // Середина = (Начало + конец) / 2

        if(searching == array[mid]) return result; // Если искомое число = середине массива, то вернуть индекс, на котором он находится.
        else if(searching < array[mid]) high = mid-1; // Также если, искомое число > середины массива, то - Конец массива = середина -1;
        else low = mid + 1; // Иначе начало массива = середина массива + 1;
        result++;
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