Console.Clear();
Console.WriteLine("Start");
Console.Write("Введите любое натуральное число: ");
//uint - использую, чтобы выводились строго положительные целые числа.
uint N = uint.Parse(Console.ReadLine());
Console.Write("Четные числа, в промежутке от 1 до " + N + ": ");
for(uint i = 1; i < N;i++){
    if (i % 2 == 0){ 
      Console.Write(i + " ");
    }
}