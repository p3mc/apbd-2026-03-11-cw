// See https://aka.ms/new-console-template for more information

using zad2;

Console.WriteLine("welcome to StatisticsHelper, this is a small change in the main branch");
Console.WriteLine("this is another change to the main branch,,, test");
Console.WriteLine("welcome to StatisticsHelper");
Console.WriteLine("redoing feature-max");

StatisticsHelper wowo = new StatisticsHelper(8);

wowo.Multiply();


double CalculateAverage(int[] values)
{
    return values.Average();
}

double CalculateMax(int[] values)
{
    return values.Max();
}

double CalculateMin(int[] values)
{
    return values.Min();
}
