using System;

namespace Lab3
{
class Programm
{
    static void Main(string[] args)
    {
        A classA = new A(2,3);
        B classB = new B(1,2,3);
        Console.WriteLine("c2="+classB.c2);
    }
}

class A
{
    public int a = 5;
    public int b = 3;

    public A(int a, int b){
        this.a=a;
        this.b=b;
        Console.WriteLine("A:a+b= "+(a+b));

    }
    public A (){}

    public int с
    {
        get { return a + b; }
        set {a = value;}
    }


}


class B: A
{
    public int d = 8;
    public int[] arr;

    public B(int a, int b, int d):base(a,b){
        this.d=d;
        arr = new int[a];
        for (int i = 0; i < a; i++){
            arr[i] = d*i;
        }
        Console.WriteLine("B:a+b+d= "+(a+b+d));
    foreach(int i in arr) Console.WriteLine(i);
    }

    public B(int d){
        this.d=d;
        Console.WriteLine("B:d= "+d);

    }

    public int c2{
        get{for(int i=0;i<3;i++)
            d=d+a+b+i;
            return d;
        }
        set{ c2 = value; }
    }


}

}


}
