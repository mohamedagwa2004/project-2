// See https://aka.ms/new-console-template for more information
int Startnumber, Endnumber;
Console.WriteLine("Please Write Perfect Number");

Console.WriteLine("______________________________________________________________________________");

Console.Write("Please Enter Start Number:-");
Startnumber = int.Parse(Console.ReadLine());

Console.Write("Please Enter End Number:-");
Endnumber = int.Parse(Console.ReadLine());

Console.WriteLine("Perfect Number" +Startnumber + "&" +Endnumber);

for (int i = Startnumber; i<= Endnumber; i++)
{
    int sum = 0;
    for (int x = 1; x<i; x++)
    {
        if (i % x ==0)
            sum = sum + x;
    }
    if (sum == i)
        Console.WriteLine("\t" + i);
}


