void Print()
{
    Console.Clear();
    Console.WriteLine("Start");
    int result = Circle();
    Console.WriteLine($"{result}");
    Console.WriteLine("End");
    
}

int GetNumber()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Circle()
{
    int value = GetNumber();
    int resultSome = 0;

    for(int count = 0; value > 0 ; count++)
    {
      value/=10;
      resultSome++;
    }
    return resultSome;

}

Print();