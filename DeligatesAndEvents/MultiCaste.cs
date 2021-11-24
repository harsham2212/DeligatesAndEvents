using System;
using System.Collections.Generic;
using System.Text;

namespace DeligatesAndEvents
{
    delegate void Delop(int x, int y);
    // Multi-caste Delegates
    public class MultiCaste
    {
        public static void ImplementDelegate()
        {
            Delop obj = Operation.Add;
            obj += Operation.Subtract;

            obj(5, 5);
            obj(8, 3);
            Console.ReadLine();
        }
        public class Operation
        {
            public static void Add(int a,int b)
            {
                Console.WriteLine("Addition ={0}", a + b);
            }
            public static void Subtract(int a, int b)
            {
                Console.WriteLine("Substraction ={0}", a - b);
            }
        }
    }
}
