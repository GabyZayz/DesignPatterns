using System;
using DesignPatternsRepository;
using DesignPatters.Models;
using DesignPattersASP.Models.ViewModels;

namespace DesignPattersASP.Strategies
{
    public class BeerWithBrandStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel berVM, IUnitOfWork unitOfWork)
        {
            var beer = new Beer();
            beer.Name = berVM.Name;
            beer.Style = berVM.Style;

            var brand = new Brand();
            brand.Name = berVM.OtherBrand;
            brand.Branid = Guid.NewGuid();
            beer.Branid = brand.Branid;

            unitOfWork.Brands.Add(brand);
            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();
        }
    }
}

