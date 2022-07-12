using System;
using DesignPatterns.DependencyInjection;
using DesignPatterns.RepositoryPattern;

namespace DesignPatterns.UnitOfWorkPattern
{
    public interface IUnitofWork
    {
        public IRepository<Beer> Beers { get; }

        public IRepository<Brand> Brands { get; }

        public void Save();
    }
}

