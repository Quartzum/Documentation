Console.Clear();
Console.WriteLine("Start");
Console.Write("Введите число: ");
int FirstNumber = int.Parse(Console.ReadLine());

if(FirstNumber % 2 == 0){
    Console.Write(FirstNumber + " - Число четное.");
} else {
    Console.Write(FirstNumber + " - Число нечетное.");
}