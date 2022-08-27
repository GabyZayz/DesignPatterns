using System;
namespace DesignPatterns.StrategyPattern
{
    public class CarStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Hola soy una moto");
        }
    }
}

