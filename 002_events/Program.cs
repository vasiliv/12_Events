using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_events
{
    public delegate void MyDelegate();
    public class MyClass
    {
        MyDelegate myEvent = null;
        public event MyDelegate MyEvent
        {
            add { myEvent += value; } // myEvent didi asoti mecera. error cs0079!!!
            remove { myEvent -= value; }
        }
        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }
    class Program
    {
        private static void handler1()
        {
            Console.WriteLine("handler1");
        }
        private static void handler2()
        {
            Console.WriteLine("handler2");
        }
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.MyEvent += handler1;
            instance.MyEvent += handler2;

            instance.InvokeEvent();
            Console.ReadLine();
        }
    }
}
