using System;
using DesignPatterns.RepositoryPattern;
using DesignPatterns.Models;

namespace DesignPatterns.UnitOfWorkPattern
{
    public interface IUnitofWork
    {
        public IRepository<Beer> Beers { get; }

        public IRepository<Brand> Brands { get; }



        public void Save();
    }
}

