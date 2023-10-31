// 3.4 средний номер 7
Console.WriteLine("|    x   |   y   ");
for (double x = Math.PI; x <= Math.PI * Math.PI; x += 0.2)
{
    double y;
    if (x < 0) y = 0.5 * x;
    else if (x >= 0 && x <= 3.6) y = 1;
    else y = Math.Exp(-(x + 0.8));
    Console.WriteLine($"|{x,8:F2}|{y,8:F2}");
    x += 0.2;
}
