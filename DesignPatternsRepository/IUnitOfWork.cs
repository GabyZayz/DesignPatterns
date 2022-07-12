using System;
using DesignPatters.Models;

namespace DesignPatternsRepository
{
    public interface IUnitOfWork
    {
        public IRepository<Beer> Beers { get; }

        public IRepository<Brand> Brands { get; }

        public void Save();
    }
}

