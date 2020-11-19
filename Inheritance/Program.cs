using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance               //belangrijk om weten: classes zijn altijd reference type
{
    public class Class1 //parent van class 1 is object    
        // wanneer je geen constructor maakt, maakt compiler zelf een default constructor
    {                           // taak van constructor is variabelen initialiseren
                                //Moet Public zijn
        public int x;
        public double btw = 21;
        public Class1(int a) //900
        {
            x = a;
            Console.WriteLine();
        }
        public string Name { get; set; }

        public void Show1()
        {
            Console.WriteLine("I am class1 method show1");
        }
        public void Show2()
        {
            Console.WriteLine("I am class1 method show2");
        }
    }
    public class Class2 : Class1// : maakt inheritance    // wanneer je geen constructor maakt, maakt compiler zelf een default constructor
    {                                                       // taak van constructor is variabelen initialiseren  
                                                            //Moet Public zijn

        public Class2(int x) : base(x)   //base stuurt nodige parameters van child naar parent class
        {
            Console.WriteLine("I am class2 constructor");
        }
        public int Age { get; set; }
       
        public void Show3()
        {
            Console.WriteLine("I am method show3");
        }

        public override string ToString()
        {
            //return base.ToString();
            string s = $"NAME: {Name} AGE: {Age} BTW: {btw}%    Dit is mijn versie(override)";
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Class2 c = new Class2();
            //c.Show1();
            //c.Show2();
            //c.Show3();

            //Class1 p = new Class1();
            int x = 20;
            //double d = 30.25;

            //Class1 p = new Class1(10);
            //Console.WriteLine(p.GetType());
            ////Class1 p;                   // variabele van parent class
            Class2 c = new Class2(900);    // instantie van child class
            //Console.WriteLine(c.GetType());                         //p = c;

            //Console.WriteLine(x.GetType());
            //Console.WriteLine(d.GetType());
            c.Name = "Toon";
            c.Age = 32;

            Console.WriteLine(c.ToString());
        }
    }
}
