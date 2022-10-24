void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    Console.Write("Введите элементы(через пробел): ");
    CheckNumber();
    Console.Write("End");
}

void CheckNumber()
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Кол-во элементов > 0: {count}.");
}
Main();