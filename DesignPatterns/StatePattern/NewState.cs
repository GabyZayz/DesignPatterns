using System;
namespace DesignPatterns.StatePattern
{
    public class NewState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            Console.WriteLine($"Se le pone dinero a su saldo {amount}");
            customerContext.Residue = amount;

            customerContext.SetState(new NoDebtorState());
        }
    }
}

