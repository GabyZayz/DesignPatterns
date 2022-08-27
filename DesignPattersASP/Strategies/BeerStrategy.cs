using System;
using DesignPatternsRepository;
using DesignPatters.Models;
using DesignPattersASP.Models.ViewModels;

namespace DesignPattersASP.Strategies
{
    public class BeerStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel berVM, IUnitOfWork unitOfWork)
        {
            var beer = new Beer();
            beer.Name = berVM.Name;
            beer.Style = berVM.Style;
            beer.Branid = (Guid)berVM.Branid;

            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();


        }
        }
    }


