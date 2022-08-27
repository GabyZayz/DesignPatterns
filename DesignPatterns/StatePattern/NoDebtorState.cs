using System;
namespace DesignPatterns.StatePattern
{
    public class NoDebtorState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            if (amount <= customerContext.Residue)
            {
                customerContext.Discount(amount);
                Console.WriteLine($"Solicitud permitida, gasta {amount} y le queda saldo {customerContext.Residue}");

                if (customerContext.Residue <= 0)
                    customerContext.SetState(new DebtorState());
            }
            else {
                Console.WriteLine($"No ajustas los solicitao yaque tienes  {customerContext.Residue} y " +
                    $"quieres gastar {amount}");

            }
                
        }
    }
}

