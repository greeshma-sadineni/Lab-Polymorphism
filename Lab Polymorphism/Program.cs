using System;

namespace Lab_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathoperations m = new Mathoperations();
            Console.WriteLine(m.Add(2, 5));
            Console.WriteLine(m.Add(2.2, 5.5,3.2));
            Console.WriteLine(m.Add(2.8m, 5.1m,2.1m));
            Console.ReadKey();
        }
    }
}
