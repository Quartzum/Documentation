// Найти наибольшее и наименьшее число из списка
Console.Clear();
Console.WriteLine("Start");

int one = -30;
int second = 40;

if(one > second){
    int max = one;
    int min = second;
    Console.WriteLine("Максимальное число - " + max);
    Console.WriteLine("Минимальное число - " + min);

} else{
    int max = second;
    int min = one;
    Console.WriteLine("Максимальное число - " + max);
    Console.WriteLine("Минимальное число - " + min);
}