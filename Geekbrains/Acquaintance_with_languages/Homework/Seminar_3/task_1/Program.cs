void Main()
{
Console.Clear();
Console.WriteLine("Start");

int number = GetNumber();
int[]array = new int [5];

int GetNumber()
{
    Console.Write("Введите пятизначное число: ");
    return int.Parse(Console.ReadLine());
}

int[] FillArray(int[]arg1, int arg2)
    {
        int i = 0;
        while(i < 5)
        {
            int residue = arg2 % 10;
            arg2 /=10;
            arg1[i] = residue;
            i++;
        }
        return arg1;
    }
int[] newArray = array;
void CheckArray(int[]arg1, int arg2)
{
    if(arg1[0] == arg1[4] & arg1[1] == arg1[3]) Console.WriteLine($"{arg2} - палиндром!");
    else Console.WriteLine($"{arg2} - не палиндром!");
}

FillArray(array, number);
CheckArray(newArray, number);

Console.WriteLine("End");
}

Main();