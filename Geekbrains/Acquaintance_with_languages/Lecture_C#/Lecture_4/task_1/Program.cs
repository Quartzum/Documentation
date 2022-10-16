int[,]empty = new int [3,4]; //Создание двумерного массива. 5 - это количество строк, 6 - количество столбцов.
int[,]FillArray(int[,]arg) //Заполнение двумерного массива случайными числами.
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
       for (int j = 0; j < arg.GetLength(1); j++)
       {
        arg[i,j] = new Random().Next(1,10);
       } 
    }
    return arg;
}
void PrintArray(int[,]arg) //Печать в консоль двумерного массива при помощи двух циклов for.
{
    for (int i = 0; i < arg.GetLength(0); i++) // Метод GetLength берет количество строк или столбцов. Здесь он берет количество строк.
    {
        for (int j = 0; j < arg.GetLength(1); j++)//Метод берет количество столбцов
        {
            Console.Write($"{arg[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,]fill = FillArray(empty);
PrintArray(fill);