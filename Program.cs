int x = 0;
int leapscore = 0;
//Asks User for year
do
{
    try
    {
        Console.Write("Give me a year to determine if that year is a leap year. >> ");
        string input = Console.ReadLine();
        x = int.Parse(input);
    }
    catch (ArgumentNullException)
    {
        Console.WriteLine("You didnt put anything in.");
        x = 0;
    }
    catch (FormatException)
    {
        Console.WriteLine("You did not put in a number. Try agian!");
        x = 0;
    }
} while (x == 0);
//Determine if the giving year is a leap year
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
if (leapscore >= 2 && leapscore != 3)
{
    Console.WriteLine("Leap Year: True");
}
else
{
    Console.WriteLine("Leap Year: Flase");
}