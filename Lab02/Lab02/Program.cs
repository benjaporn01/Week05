
using System;
public class GotoTest
{
    static void Main(string[] args)
    {
        Console.WriteLine("Line 1");
        goto line4;
        goto line9;
    line2:
        Console.WriteLine("Line 2");
        goto line9;
    line3:
        Console.WriteLine("Line 3");
    line4:
        Console.WriteLine("Line 4");
        Console.WriteLine("Line 5");
        goto line2;
    line9:
        Console.WriteLine("Line 9");
    
    }
}
