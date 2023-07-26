System.Console.Write("From = ");
int from=Convert.ToInt32(Console.ReadLine());
System.Console.Write("To = ");
int to=Convert.ToInt32(Console.ReadLine());

for (int i = from; i <= to; i++)
{
    System.Console.WriteLine();
    System.Console.WriteLine($"{i}*1={i*1}");
    System.Console.WriteLine($"{i}*2={i*2}");
    System.Console.WriteLine($"{i}*3={i*3}");
    System.Console.WriteLine($"{i}*4={i*4}");
    System.Console.WriteLine($"{i}*5={i*5}");
    System.Console.WriteLine($"{i}*6={i*6}");
    System.Console.WriteLine($"{i}*7={i*7}");
    System.Console.WriteLine($"{i}*8={i*8}");
    System.Console.WriteLine($"{i}*9={i*9}");
    System.Console.WriteLine($"{i}*10={i*10}");
    System.Console.WriteLine("----------");
}