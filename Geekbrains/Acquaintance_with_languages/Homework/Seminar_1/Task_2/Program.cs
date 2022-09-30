Console.Clear();
Console.WriteLine("Start");
Console.Write("Введите первое число: ");
int FirstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int SecondNumber = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int ThirdNumber = int.Parse(Console.ReadLine());

if(FirstNumber == SecondNumber && FirstNumber == ThirdNumber){
    Console.Write("Максимального числа нет, т.к. все числа равны");
} else if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber){
    Console.Write(FirstNumber + " - Максимальное число");
} else if (SecondNumber > FirstNumber && SecondNumber > ThirdNumber){
    Console.Write(SecondNumber + " - Максимальное число");
} else if (ThirdNumber > FirstNumber && ThirdNumber > SecondNumber){
    Console.Write(ThirdNumber + " - Максимальное число");
}