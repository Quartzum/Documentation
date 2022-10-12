Console.Clear();
int xa = 1, ya = 1,
    xb = 1, yb = 5,
    xc = 5, yc = 40;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while(count < 100)
{
    int what = new Random().Next(0, 3);
    if(what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
    if(what == 1)
    {
        x = (x +xb)/2;
        y = (y+yb)/2;
    }
    if(what == 2)
    {
        x = (x +xc)/2;
        y = (y+yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}