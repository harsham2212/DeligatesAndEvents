using System;

namespace DeligatesAndEvents
{
    class Program
    {
        public static event DelEventHandler add;
        static void Main(string[] args)
        {
            operation obj = new operation(DeligatesDemo.Addition);
            //Console.WriteLine("Addition:{0}", obj(11, 27));
            MultiCaste.ImplementDelegate();

            add += new DelEventHandler(EventHandler.India);
            add += new DelEventHandler(EventHandler.USA);
            add += new DelEventHandler(EventHandler.London);
            add.Invoke();
            
        }
    }
}
 


