namespace zad2;

public class StatisticsHelper
{
    private int a;
    
    public StatisticsHelper(int a)
    {
        this.a = a;
    }

    public void Multiply()
    {
        a = a * 2;
        Console.WriteLine($"a*2={a}");
    }
}