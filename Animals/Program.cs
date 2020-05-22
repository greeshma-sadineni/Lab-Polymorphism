using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("john","Whiskas");
            Animal Dog = new Dog("hony", "Meat");
            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(Dog.ExplainSelf());
            Console.ReadKey();
        }
    }
}
