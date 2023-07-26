public class Calculator
{
    public int FisrtNum;
    public int SecondNum;
    public char Operation;

    public void Sum()
    {
        System.Console.WriteLine($"{FisrtNum} + {SecondNum} = {FisrtNum+SecondNum}");
    }
    public void Subtract()
    {
        System.Console.WriteLine($"{FisrtNum} - {SecondNum} = {FisrtNum-SecondNum}");
    }
    public void Multiplication()
    {
        System.Console.WriteLine($"{FisrtNum} * {SecondNum} = {FisrtNum*SecondNum}");
    }
    public void Division()
    {
        System.Console.WriteLine($"{FisrtNum} / {SecondNum} = {FisrtNum/(double)SecondNum}");
    }
}