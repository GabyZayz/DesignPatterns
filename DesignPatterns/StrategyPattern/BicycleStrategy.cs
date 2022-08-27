using System;
namespace DesignPatterns.StrategyPattern
{
    public class BicycleStrategy :IStrategy
    {
       public void Run()
        {
            Console.WriteLine(" Soy una bicileta");
        }
    }
}

