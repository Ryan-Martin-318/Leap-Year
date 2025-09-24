//Asks User for year
Console.Write("Give me a year to determin if that year is a leap year. >> ");
int x = Convert.ToInt32(Console.ReadLine());
int leapscore = 0;
//Determins if the giving year is a leap year
if (x % 2 == 0)
{
    Console.WriteLine("Even: True");
    leapscore = leapscore + 1;
}
else
{
    Console.WriteLine("Even: False");
}

if (x % 4 == 0)
{
    Console.WriteLine("Divisable by 4: True");
    leapscore = leapscore + 1;
}
else
{
    Console.WriteLine("Divisable by 4: False");
}

if (x % 100 == 0)
{
    Console.WriteLine("Divisable by 100: True");
    leapscore = leapscore + 1;
    if (x % 400 == 0)
{
    Console.WriteLine("Divisable by 400: True");
    leapscore = leapscore + 1;
}
    else
{
    Console.WriteLine("Divisable by 400: False");
}
}
else
{
    Console.WriteLine("Divisable by 100: False");
}

if (leapscore >= 2)
{
    if (leapscore != 3)
    {
        Console.WriteLine("Leap Year: True");

    }
}
else
{
    Console.WriteLine("Leap Year: Flase");
}