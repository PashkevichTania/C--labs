using System;

class Programm
{
    static void Main(string[] args)
    {
        A obj = new A();
        Console.WriteLine(obj.Operation("-"));
        Console.ReadKey();
    }
}
 
class A
{
    private int a = 5;
    private int b = 3;
 
    public int с
    {
        get { return a + b; }
    }
 
    public int Operation(string str)
    {
        switch (str)
        {
            case "+": return a + b;
            case "-": return a - b;
        }
 
        return 0;
    }
}


