using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_events
{
    public delegate void MyDelegate();
    class MyClass
    {
        public event MyDelegate MyEvent;
        public void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }
    class Program
    {
        private static void EventHandler1()
        {
            Console.WriteLine("handler1");
        }
        private static void EventHandler2()
        {
            Console.WriteLine("handler2");
        }
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.MyEvent += new MyDelegate(EventHandler1);
            instance.MyEvent += EventHandler2; // no brackets

            instance.InvokeEvent();
            Console.ReadLine();
        }
    }
}
