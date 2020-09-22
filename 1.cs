using System;

class Programm
{
    static void Main(string[] args)
    {
        A obj = new A();
        Console.WriteLine(obj.Operation("*"));
        Console.ReadKey();
    }
}
 
class A
{
    private int a = 14;
    private int b = 5;
 
    public int с
    {
        get { return a + b; }
    }
 
    public int Operation(string str)
    {
        switch (str)
        {
            case "*": return a * b;
            case "-": return a - b;
        }
 
        return 0;
    }
}


