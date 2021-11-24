using System;
using System.Collections.Generic;
using System.Text;

namespace DeligatesAndEvents
{
    public delegate void DelEventHandler();
    class EventHandler
    {
        public static void India()
        {
            Console.WriteLine("India");
        }
        public static void USA()
        {
            Console.WriteLine("USA");
        }
        public static void London()
        {
            Console.WriteLine("London");
        }
    }
}
