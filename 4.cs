using System;

namespace lab4{

    public class Program{
        static void Main(string[] args){
			B myB = new B();	
			Console.WriteLine("First array");
            for(int i = 0; i < myB.a; i++){
                Console.WriteLine(myB[i]);
            }
            Console.WriteLine("Second array");
            for(int i = 0; i < 5; i++){
                Console.WriteLine(myB[(short)i]);
            }

			C<int> myC = new C<int>();
			C<string> otherC = new C<string>();
			C<int>.staticField = "New static value";
			otherC.currentValue = "String";
			myC.currentValue = 13;	
        }
    }   

    class A{
        public float a = 2, b = 3;
        private bool state = false; 
        
        public A(){
			a = 2;
			b = 3;
			state = false;
        } 

        public bool State{
            set{
                state = value;
            }
        }
        public float c {
            get{
                if(state){
                    return a / b;
                }
                else
                {
                    return a - b;
                }
            }
        }
    }

    class B: A{
        private float d;
		public float[] ar;
        private float[] otherAr = {2.3f,33.05f,5.7f,0.7f,8.9f};

        public float this[int index]{
            get{return ar[index];}
            set{ar[index] = value;}        
        }

        public float this[short index]{
            get{return otherAr[index];}
            set{otherAr[index] = value;}        
        }

		public B(float d){
			this.d = d;
		}

		public B():base(){
			ar = new float[(int)a];	
			for(int i = 0; i < ar.Length; i++){
				ar[i] = c2*i;			
			}
		}

        public float c2 {
            get{
				if(d > 2){
					return base.c + d;				
				}
				else
				{
					return base.c - d;
				}
            }
        }
    }

	class C<T>
	{
		public static string staticField;
		public T currentValue;	
	}
}
