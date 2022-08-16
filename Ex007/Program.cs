Console.Clear();

int xa = 35, ya = 1,
    xb = 1, yb = 25,
    xc = 70, yc = 25;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

int x = xa, y = ya,
    count = 0;

while (count < 10000)
{
    int rnd = new Random().Next(0, 3);

    if(rnd == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    
    if(rnd == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(rnd == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");

    count++;


}