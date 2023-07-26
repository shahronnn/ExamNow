var calculator = new Calculator();
System.Console.Write("First number = ");
calculator.FisrtNum=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Second number = ");
calculator.SecondNum=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Operation = ");
calculator.Operation=Convert.ToChar(Console.ReadLine());
if (calculator.Operation=='+')
{
    System.Console.WriteLine();
    calculator.Sum();
}
if (calculator.Operation=='-')
{
    System.Console.WriteLine();
    calculator.Subtract();
}
if (calculator.Operation=='*')
{
    System.Console.WriteLine();
    calculator.Multiplication();
}
if (calculator.Operation=='/')
{
    System.Console.WriteLine();
    calculator.Division();
}