Console.WriteLine("Start");
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int result = num / 10 % 10;

if(result < 0){
    result = result * -1;
    Console.WriteLine($"Второе число {num} : {result}.");
} else{
    Console.WriteLine($"Второе число {num} : {result}.");
}
