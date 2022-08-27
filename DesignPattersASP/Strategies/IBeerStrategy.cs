using System;
using DesignPatternsRepository;
using DesignPattersASP.Models.ViewModels;

namespace DesignPattersASP.Strategies
{
    public interface IBeerStrategy
    {

        public void Add(FormBeerViewModel berVM,
            IUnitOfWork unitOfWork);
    }
}

