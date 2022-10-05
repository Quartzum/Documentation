/*14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if(num % 7 == 0 && num % 23 == 0){
    Console.WriteLine($"Число {num} кратно 7 и 23!");
} else {
    Console.Write($"Число {num} некратно 7 и 23!");
}
