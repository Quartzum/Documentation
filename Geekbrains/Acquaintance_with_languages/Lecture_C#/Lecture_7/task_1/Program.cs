string NumberFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
       result += $"{i}";
    }
    return result;
}
string NumberRec(int a, int b)
{
    if(a <= b) return $"{a}" + NumberRec(a + 1, b);
    else return String.Empty;
}
Console.WriteLine(NumberFor(1, 10));
Console.WriteLine(NumberRec(1, 10));