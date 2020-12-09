using System;

namespace Lab_5
{
    using System;

    namespace lab4
    {
        public class Program
        {
            static void Main(string[] args)
            {
                B b1 = new B(-3);
                B b2 = new B(4);
                if (b1)
                {
                    Console.WriteLine("b1 = " + true);
                }
                else {
                    Console.WriteLine("b1 = " + false);
                }

                if (b2)
                {
                    Console.WriteLine("b2 = " + true);
                }
                else
                {
                    Console.WriteLine("b2 = " + false);
                }

                if (b1 & b2)
                {
                    Console.WriteLine("b1 & b2 = " + true);
                }
                else
                {
                    Console.WriteLine("b1 & b2 = " + false);
                }
            }
        }

        class A
        {
            public float a = 2, b = 3;
            private bool state = false;

            public A()
            {
                a = 2;
                b = 3;
                state = false;
            }

            public bool State
            {
                set
                {
                    state = value;
                }
            }
            public float c
            {
                get
                {
                    if (state)
                    {
                        return a / b;
                    }
                    else
                    {
                        return a - b;
                    }
                }
            }
        }

        class B : A
        {
            private float d;
            public float[] ar;
            private float[] otherAr = { 2.3f, 33.05f, 5.7f, 0.7f, 8.9f };

            public float this[int index]
            {
                get { return ar[index]; }
                set { ar[index] = value; }
            }

            public float this[short index]
            {
                get { return otherAr[index]; }
                set { otherAr[index] = value; }
            }

            public B(float d)
            {
                this.d = d;
            }

            public B() : base()
            {
                ar = new float[(int)a];
                for (int i = 0; i < ar.Length; i++)
                {
                    ar[i] = c2 * i;
                }
            }

            public float c2
            {
                get
                {
                    if (d > 2)
                    {
                        return base.c + d;
                    }
                    else
                    {
                        return base.c - d;
                    }
                }
            }

            public static bool operator true(B par1)
            {
                return par1.d >= 0;
            }

            public static bool operator false(B par1) {
                return par1.d < 0;
            }

            public static bool operator &(B par1, B par2) {
                return (par1.d * par2.d) > 0;
            }
        }

        class C<T>
        {
            public static string staticField;
            public T currentValue;
        }
    }

}
