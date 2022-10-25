using System.Text;

class Program
{
    static string DecimalToBinary(uint decimalNumber)
    {
        var binaryNumber = string.Empty;
        while (decimalNumber > 0)
        {
            binaryNumber = (decimalNumber % 2) + binaryNumber;
            decimalNumber /= 2;
        }

        return binaryNumber;
    }
    
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Введите число в десятичной системе: ");
        var decNum = uint.Parse(Console.ReadLine());
        var binNum = DecimalToBinary(decNum);
        Console.WriteLine($"{decNum} => {binNum}");
        Console.ReadLine();
    }
}