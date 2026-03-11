// See https://aka.ms/new-console-template for more information

using zad2;

Console.WriteLine("welcome to StatisticsHelper, this is a small change in the main branch");

StatisticsHelper wawa = new StatisticsHelper(8);

wawa.Multiply();

double CalculateAverage(int[] values)
{
    return values.Average();
}

double CalculateMax(int[] values)
{
    return values.Max();
}
