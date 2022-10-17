void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[]fill = FillArray(GetSizeArray(), GetMinNumber(), GetMaxNumber());
    Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях - {SetSummArray(fill)}.");
    Console.WriteLine("End");
}
int GetSizeArray()
{
    Console.Write("Введите размер массива: ");
    return int.Parse(Console.ReadLine());
}
int GetMinNumber()
{
    Console.Write("Введите минимальное значение предела: ");
    return int.Parse(Console.ReadLine());
}
int GetMaxNumber()
{
    Console.Write("Введите максимальное значение предела: ");
    return int.Parse(Console.ReadLine());
}
int[]FillArray(int arg1, int arg2, int arg3)
{
    int[]empty = new int[arg1];
    for (int i = 0; i < empty.Length; i++)
    {
        empty[i] = new Random().Next(arg2, arg3);
    }
    return empty;
}
int SetSummArray(int[]arg1)
{
    int summ = 0;
    for (int i = 0; i < arg1.Length; i++)
    {
        if(i == 0)summ += arg1[i];
        else if(i % 2 == 0)summ +=arg1[i];
        Console.WriteLine($"Элемент номер:{i} - {arg1[i]}");
    }
    return summ;
    /*По задаче: Найдите сумму элементов, стоящих на нечётных позициях.
    Если брать в расчет, что позиция - это индекс, а элемент - это то, что находится в индексе,
    то алгоритм будет следующим образом работать:
    1. Если индекс = 0, то элемент суммируется с результатом.
    0 - я считаю, как нечетную позицию и от этого отталкиваюсь. Все таки в задаче не написано, относительно
    чего считать нечетную позицию.
    Т.е. индекс 0 - это позиция 1(а один нечетное число).
    1 - четная.
    2 - нечетная.
    3 - четная.
    и т.д.
    */
    
}
Main();