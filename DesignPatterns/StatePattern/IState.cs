using System;
namespace DesignPatterns.StatePattern
{
    public interface IState
    {
        public void Action( CustomerContext customerContext, decimal amount);
    }
}

