Console.Clear();
Console.WriteLine("Start");
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int result = num / 10 % 10;

if(num > 99 && num < 1000){
    Console.WriteLine($"Второе число {num} - {result} .");
} else if(num < -99 && num > -1000) {
    result = result * -1;
    Console.WriteLine($"Второе число {num} - {result} .");
} else {
    Console.WriteLine($"{num} - некорректное число!Введите трехзначное число в консоль!");
}