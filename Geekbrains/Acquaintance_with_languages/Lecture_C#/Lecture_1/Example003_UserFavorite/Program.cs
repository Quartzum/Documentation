Console.WriteLine("Введите имя пользователя: ");
string userName = Console.ReadLine();

if(userName.ToLower() == "viktor")
{
    Console.WriteLine("Ура, это же Viktor!");
}
else
{
    Console.WriteLine("Привет");
    Console.WriteLine(userName);
}