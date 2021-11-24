using System;
using System.Collections.Generic;
using System.Text;

namespace DeligatesAndEvents
{
    public delegate int operation(int x, int y);

    public class DeligatesDemo
    {
        public static int Addition(int a,int b)
        {
            return a + b;
        }
    }
}

