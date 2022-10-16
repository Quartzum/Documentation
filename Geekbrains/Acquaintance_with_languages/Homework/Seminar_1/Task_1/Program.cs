Console.Clear();
Console.WriteLine("Start");
Console.Write("Введите первое число: ");
int FirstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int SecondNumber = int.Parse(Console.ReadLine());

if(FirstNumber > SecondNumber){
    Console.WriteLine(FirstNumber + " - Максимальное число.");
    Console.WriteLine(SecondNumber + " - Минимальное число.");
} else if(FirstNumber < SecondNumber) {
    Console.WriteLine(SecondNumber + " - Максимальное число.");
    Console.WriteLine(FirstNumber + " - Минимальное число.");
} else {
    Console.WriteLine("Максимального и минимального числа нет, т.к. они равны");
}